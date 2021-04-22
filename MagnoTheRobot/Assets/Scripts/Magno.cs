using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Magno : MonoBehaviour
{

    public float walkSpeed;
    public float turnSpeed;
    public float lookSpeed;
    public Transform camHolder;   

    private Animator animr;
    private Camera cam;

    // Movement Control Bools
    private bool forward;
    private bool backward;
    private bool turnLeft;
    private bool turnRight;


    private void Awake()
    {
        animr = GetComponent<Animator>();
        cam = FindObjectOfType<Camera>();
    }

    // Start is called before the first frame update
    void Start()
    {
        if(walkSpeed == 0)
        {
            walkSpeed = 6;
        }
        if(turnSpeed == 0)
        {
            turnSpeed = 360;
        }
        if(lookSpeed == 0)
        {
            lookSpeed = 20;
        }

    }

    // Update is called once per frame
    void Update()
    {
        ApplyMotion();
    }

    private void ApplyMotion()
    {
        if(forward)
        {
            transform.position += transform.forward * Time.deltaTime * walkSpeed;
        }        
        else if(backward)
        {
            transform.position += transform.forward * Time.deltaTime * -walkSpeed;
        }

        animr.SetBool("walk", forward);
        animr.SetBool("walkBack", backward);

        if (turnLeft)
        {
            transform.Rotate(0, -turnSpeed * Time.deltaTime, 0);
        }
        else if (turnRight)
        {
            transform.Rotate(0, turnSpeed * Time.deltaTime, 0);
        }
    }


    private void ScanAhead()
    {
        //cam.Scr
    }


    public void OnForward(InputValue val)
    {
        if(val.isPressed)
        {
            forward = true;
            backward = false;
        }
        else
        {
            forward = false;
        }
    }
    public void OnBack(InputValue val)
    {
        if(val.isPressed)
        {
            backward = true;
            forward = false;
        }
        else
        {
            backward = false;
        }
    }
    public void OnTurnLeft(InputValue val)
    {
        if(val.isPressed)
        {
            turnLeft = true;
            turnRight = false;
        }
        else
        {
            turnLeft = false;
        }
    }
    public void OnTurnRight(InputValue val)
    {
        if(val.isPressed)
        {
            turnRight = true;
            turnLeft = false;
        }
        else
        {
            turnRight = false;
        }
    }
    public void OnPause(InputValue val)
    {

    }
    public void OnPush(InputValue val)
    {

    }
    public void OnPull(InputValue val)
    {

    }
    public void OnLock(InputValue val)
    {

    }
    public void OnLookUp(InputValue val)
    {
        float rotator = -val.Get<float>();

        camHolder.Rotate(rotator * Time.deltaTime * lookSpeed, 0, 0);

        float x = camHolder.rotation.eulerAngles.x;

        Debug.Log(x);

        //else if (x < -30)
        //{
        //    float delta = -30 - x;
        //    camHolder.Rotate(delta, 0, 0);
        //    Debug.Log("Under MINUS 30");
        //}

        if (rotator > 0)
        {
            Debug.Log("Mouse Down");
            if (x > 30 && x < 300)
            {
                float delta = 30 - x;
                camHolder.Rotate(delta, 0, 0);
                Debug.Log("Over 30");
            }
        }
        if (rotator < 0)
        {
            Debug.Log("Mouse Up");
            if (x > 30 && x < 300)
            {
                float delta = 300 - x;
                camHolder.Rotate(delta, 0, 0);
                Debug.Log("Under MINUS 30");
            }
        }

    }

}
