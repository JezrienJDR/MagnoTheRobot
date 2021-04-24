using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GreatMonolith : MonoBehaviour
{
    public Image panel;



    public void FadeToWhite()
    {
        StartCoroutine("Fade");
    }

    IEnumerator Fade()
    {        
        for(int i = 0; i < 200; i++)
        {
            panel.color = Color.Lerp(Color.clear, Color.white, i / 200.0f);
            //panel.tintColor = Color.Lerp(Color.clear, Color.white, i / 1000.0f);
            yield return new WaitForSeconds(0.01f);
        }

        Cursor.lockState = CursorLockMode.None;

        SceneManager.LoadScene("StartScene");
    }

    private void OnCollisionEnter(Collision collision)
    {
        FadeToWhite();
    }
}
