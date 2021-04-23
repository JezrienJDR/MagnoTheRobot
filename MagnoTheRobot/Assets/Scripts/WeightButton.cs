using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeightButton : MonoBehaviour
{
    private bool isPressed;
    private int numObjects;
    public Transform button;
    private Material mat;

    private PuzzleController1 puzzleCon;

    private void OnTriggerEnter(Collider other)
    {
        numObjects++;
        
        if (isPressed == false)
        {
            isPressed = true;
            puzzleCon.ButtonPress(true);
            StartCoroutine("ButtonDown");
            Debug.Log(other.name);
        }

    }

    private void OnTriggerExit(Collider other)
    {
        numObjects--;

        if (numObjects <= 0)
        {
            isPressed = false;
            puzzleCon.ButtonPress(false);
            StartCoroutine("ButtonUp");
        }
    }


    IEnumerator ButtonDown()
    {
        Vector3 moveVector = new Vector3(0, -0.01f, 0);
        

        for (int i = 0; i < 15; i++)
        {
            button.localPosition += moveVector;
            mat.SetColor("_Color", Color.Lerp(Color.red * 1.1f, Color.green * 1.1f, 0.0667f * i));
            yield return new WaitForSeconds(0.01f);
        }
    }

    IEnumerator ButtonUp()
    {
        Vector3 moveVector = new Vector3(0, 0.01f, 0);


        for (int i = 0; i < 15; i++)
        {
            button.localPosition += moveVector;
            mat.SetColor("_Color", Color.Lerp(Color.green * 1.1f, Color.red * 1.1f, 0.0667f * i));
            yield return new WaitForSeconds(0.01f);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        puzzleCon = FindObjectOfType<PuzzleController1>();
        mat = button.GetComponent<MeshRenderer>().material;
        mat.SetColor("_Color", Color.red * 1.1f);
        numObjects = 0;
    }

    // Update is called once per frame
   
}
