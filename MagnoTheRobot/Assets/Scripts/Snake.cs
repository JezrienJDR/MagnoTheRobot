using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snake : MonoBehaviour
{
    private int health = 4;
    private Animator animr;

    Material mat;

    public float velocityThreshold;
    // Start is called before the first frame update

    private AudioSource hurtSound;
    private AudioSource deathSound;

    private void Awake()
    {
        animr = GetComponent<Animator>();
        mat = GetComponentInChildren<SkinnedMeshRenderer>().material;

        hurtSound = GetComponents<AudioSource>()[0];
        deathSound = GetComponents<AudioSource>()[1];
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.relativeVelocity.magnitude > velocityThreshold)
        {
            health--;
            if(health <= 0)
            {
                animr.SetBool("die", true);
                deathSound.Play();
            }
            else
            {
                animr.SetBool("hurt", true);
                hurtSound.Play();
            }
        }
    }

    public void HurtDone()
    {
        animr.SetBool("hurt", false);
    }

    public void Death()
    {
        FindObjectOfType<MusicManager>().StartEndMusic();
        StartCoroutine("DeathFade");
    }

    IEnumerator DeathFade()
    {
        for(int i = 0; i < 100; i++)
        {
            mat.SetFloat("_Fade", Mathf.Lerp(0.5f, -0.5f, i / 100.0f));
            yield return new WaitForSeconds(0.02f);
        }

        Destroy(gameObject);
    }
}
