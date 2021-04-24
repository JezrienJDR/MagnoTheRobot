using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    public void QuitGame()
    {
        Application.Quit();
    }

    public void StartGame()
    {
        //GameObject g = FindObjectOfType<MusicManager>().gameObject;
        
        if(FindObjectOfType<MusicManager>() != null)
        {
            Destroy(FindObjectOfType<MusicManager>().gameObject);
        }

        SceneManager.LoadScene("SampleScene");
    }

    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void Instructions()
    {
        SceneManager.LoadScene("Instructions");
    }

    public void ReturnToMain()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("StartScene");
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        Cursor.lockState = CursorLockMode.Locked;
        gameObject.SetActive(false);
    }

}
