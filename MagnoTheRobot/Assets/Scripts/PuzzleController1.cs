using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleController1 : MonoBehaviour
{
    
    public Door door1;
    public Door door2;

    private int numButtonsPressed;

    // Start is called before the first frame update
    void Start()
    {
        numButtonsPressed = 0;
        door2.Open();
    }

    public void ButtonPress(bool pressed)
    {
        if(pressed)
        {
            numButtonsPressed += 1;
        }
        else
        {
            numButtonsPressed -= 1;
        }

        if(numButtonsPressed == 2)
        {
            door1.Open();
            door2.Close();
        }
        else
        {
            door2.Open();
            door1.Close();
        }
    }

}
