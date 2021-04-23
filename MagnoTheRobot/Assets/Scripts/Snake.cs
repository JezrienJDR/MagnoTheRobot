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

    private void Awake()
    {
        animr = GetComponent<Animator>();
        mat = GetComponentInChildren<SkinnedMeshRenderer>().material;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.relativeVelocity.magnitude > velocityThreshold)
        {
            health--;
            if(health <= 0)
            {
                animr.SetBool("die", true);
            }
            else
            {
                animr.SetBool("hurt", true);
            }
        }
    }

    public void HurtDone()
    {
        animr.SetBool("hurt", false);
    }

    public void Death()
    {
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
