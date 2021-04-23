using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    private bool isOpen;
    private BoxCollider box;

    public Transform leftDoor;
    public Transform rightDoor;

    private AudioSource audSrc;

    public void Open()
    {
        if (!isOpen)
        {
            isOpen = true;
            StartCoroutine("Opening");
            box.enabled = false;

            if(audSrc != null)
            {
                audSrc.Play();
            }
        }
    }

    public void Close()
    {
        if (isOpen)
        {
            isOpen = false;
            StartCoroutine("Closing");
            box.enabled = true;


            if (audSrc != null)
            {
                audSrc.Play();
            }
        }
    }
    
    IEnumerator Opening()
    {
        yield return new WaitForSeconds(0.3f);

        Vector3 leftVector = new Vector3(0.2f, 0, 0);
        Vector3 rightVector = new Vector3(-0.12f, 0, 0);

        for (int i = 0; i < 20; i++)
        {
            leftDoor.localPosition += leftVector;
            rightDoor.localPosition += rightVector;
            yield return new WaitForSeconds(0.01f);
        }
    }

    IEnumerator Closing()
    {
        Vector3 leftVector = new Vector3(-0.2f, 0, 0);
        Vector3 rightVector = new Vector3(0.12f, 0, 0);

        for (int i = 19; i > -1; i--)
        {
            leftDoor.localPosition += leftVector;
            rightDoor.localPosition += rightVector;
            yield return new WaitForSeconds(0.01f);
        }
    }

    IEnumerator TestLoop()
    {
        for (int i = 0; i < 5; i++)
        {

            StartCoroutine("Opening");

            yield return new WaitForSeconds(1.0f);

            StartCoroutine("Closing");

            yield return new WaitForSeconds(1.0f);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        box = GetComponent<BoxCollider>();

        audSrc = GetComponent<AudioSource>();
    }
    

}
