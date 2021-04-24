using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public AudioSource startMusic;
    public AudioSource fightMusic;
    public AudioSource endMusic;

    private bool fightStarted;



    public void StartFightMusic()
    {
        Debug.Log("StarFightMusic function called!");
        StartCoroutine("fightStart");
    }

    public void StartEndMusic()
    {
        StartCoroutine("endStart");

        DontDestroyOnLoad(gameObject);
    }

    IEnumerator fightStart()
    {
        Debug.Log("fightStart Coroutine Started!");

        fightMusic.volume = 0.0f;
        fightMusic.Play();

        for(int i = 0; i < 100; i++)
        {
            startMusic.volume = Mathf.Lerp(1.0f, 0.0f, i / 100.0f);
            fightMusic.volume = Mathf.Lerp(0.0f, 1.0f, i / 100.0f);

            yield return new WaitForSeconds(0.01f);
        }

        startMusic.Stop();
    }

    IEnumerator endStart()
    {
        endMusic.volume = 0.0f;
        endMusic.Play();

        for (int i = 0; i < 100; i++)
        {
            fightMusic.volume = Mathf.Lerp(1.0f, 0.0f, i / 100.0f);
            endMusic.volume = Mathf.Lerp(0.0f, 1.0f, i / 100.0f);

            yield return new WaitForSeconds(0.01f);
        }

        fightMusic.Stop();
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collision Entered!");

        if (!fightStarted)
        {
            StartFightMusic();
            fightStarted = true;
        }
    }
    
}
