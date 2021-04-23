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
    public LayerMask groundMask;
    private Animator animr;
    private Camera cam;


    // Movement Control Bools
    private bool forward;
    private bool backward;
    private bool left;
    private bool right;
    private bool turnLeft;
    private bool turnRight;
    private bool onGround;

    private MetalItem target;
    int targetID;

    private float mass;
    private Rigidbody rb;
    private CapsuleCollider cap;

    // Allomancy variables
    private bool pushing;
    private bool pulling;
    private float pushForce;
    private float pullForce;
    public float basePushForce;
    public float basePullForce;

    // Line Renderer
    private LineRenderer line;
    private Material mat;

    private void Awake()
    {
        animr = GetComponent<Animator>();
        cam = FindObjectOfType<Camera>();

        rb = GetComponent<Rigidbody>();
        mass = rb.mass;

        cap = GetComponent<CapsuleCollider>();

        line = GetComponent<LineRenderer>();
        mat = line.material;
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
            turnSpeed = 250;
        }
        if(lookSpeed == 0)
        {
            lookSpeed = 30;
        }

        targetID = 9002;

        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        GroundCheck();
        ApplyMotion();
        ScanAhead();
        Allomancy();
    }

    private void GroundCheck()
    {
        RaycastHit hit;
        if (Physics.BoxCast(transform.position + new Vector3(0,0,0), new Vector3(0.5f, 0.5f, 0.5f), Vector3.down, out hit, Quaternion.identity, 1.0f, groundMask))
        {
            onGround = true;
        }
        else
        {
            onGround = false;
        }

        //Debug.DrawLine(transform.position  + new Vector3(0,1,0), transform.position + Vector3.down * 30);


        animr.SetBool("air", !onGround);
        //Debug.Log(onGround);
    }

    private void ApplyMotion()
    {
        if (onGround)
        {
            if (forward)
            {
                transform.position += transform.forward * Time.deltaTime * walkSpeed;
            }
            else if (backward)
            {
                transform.position += transform.forward * Time.deltaTime * -walkSpeed;
            }
            else if (left)
            {
                transform.position += transform.right * Time.deltaTime * -walkSpeed;
            }
            else if (right)
            {
                transform.position += transform.right * Time.deltaTime * walkSpeed;
            }
        }

        animr.SetBool("walkForward", forward);
        animr.SetBool("walkBack", backward);
        animr.SetBool("walkLeft", left);
        animr.SetBool("walkRight", right);


        if (turnLeft)
        {
            transform.Rotate(0, -turnSpeed * Time.deltaTime, 0);
        }
        else if (turnRight)
        {
            transform.Rotate(0, turnSpeed * Time.deltaTime, 0);
        }
    }

    private void Allomancy()
    {
        if (targetID == 9002)
        {
            //Debug.Log("NO TARGET");
            return;
        }

        float magnitude = 0.0f;

        if(pushing)
        {
            magnitude = basePushForce;
            line.SetPosition(1, target.transform.position);
        }
        else if(pulling)
        {
            magnitude = basePullForce;
            line.SetPosition(1, target.transform.position);
        }
        else
        {
            line.SetPosition(1, transform.position);
        }

        if(mass > target.GetMass())
        {
            Vector3 f = Vector3.Normalize(transform.position - target.transform.position) * magnitude;

            target.ApplyForce(f);
        }
        else if(mass < target.GetMass())
        {
            Vector3 f = Vector3.Normalize(target.transform.position - transform.position) * magnitude;
            f.Scale(new Vector3(400, 60, 400));

            rb.AddForce(f);
        }

        line.SetPosition(0, transform.position);
        

        //Debug.Log(rb.velocity);
    }

    private void ScanAhead()
    {
        
        Ray ray = cam.ScreenPointToRay(new Vector2(Screen.width / 2, Screen.height / 2));
        RaycastHit hit;

        Debug.DrawRay(ray.origin, ray.direction * 10, Color.red);

        if(Physics.Raycast(ray, out hit))
        {
            if(hit.transform.CompareTag("Metal"))
            {
                //Debug.Log("TARGET ACQUIRED");
                SetTarget(hit.transform.GetComponent<MetalItem>());
            }
        }
    }

    private void SetTarget(MetalItem t)
    {
        if(target != null && t.GetID() != targetID)
        {
            target.FadeGlow();
        }

        if (t.GetID() != targetID)
        {
            target = t;
            targetID = target.GetID();
            target.ShowGlow();
        }
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
            left = true;
            right = false;
        }
        else
        {
            left = false;
        }
    }
    public void OnTurnRight(InputValue val)
    {
        if(val.isPressed)
        {
            right = true;
            left = false;
        }
        else
        {
            right = false;
        }
    }
    public void OnPause(InputValue val)
    {

    }
    public void OnPush(InputValue val)
    {
        //Debug.Log("PUSHING!");
        if(val.isPressed == true)
        {
            pushing = true;
            mat.SetFloat("_Dir", -1);
        }
        else
        {
            pushing = false;
            pushForce = 0.0f;
        }
           
    }
    public void OnPull(InputValue val)
    {
        if (val.isPressed == true)
        {
            pulling = true;
            mat.SetFloat("_Dir", 1);
        }
        else
        {
            pulling = false;
            pullForce = 0.0f;
        }
    }
    public void OnLock(InputValue val)
    {

    }
    public void OnLookUp(InputValue val)
    {
        float rotator = -val.Get<float>();

        camHolder.Rotate(rotator * Time.deltaTime * lookSpeed, 0, 0);

        float x = camHolder.rotation.eulerAngles.x;

        //Debug.Log(x);

        //else if (x < -30)
        //{
        //    float delta = -30 - x;
        //    camHolder.Rotate(delta, 0, 0);
        //    Debug.Log("Under MINUS 30");
        //}

        if (rotator > 0)
        {
            //Debug.Log("Mouse Down");
            if (x > 80 && x < 300)
            {
                float delta = 80 - x;
                camHolder.Rotate(delta, 0, 0);
                //Debug.Log("Over 30");
            }
        }
        if (rotator < 0)
        {
            //Debug.Log("Mouse Up");
            if (x > 80 && x < 300)
            {
                float delta = 300 - x;
                camHolder.Rotate(delta, 0, 0);
                //Debug.Log("Under MINUS 30");
            }
        }

    }
    public void OnLookX(InputValue val)
    {
        if(val.Get<float>() > 0)
        {
            turnRight = true;
            turnLeft = false;
        }
        else if(val.Get<float>() < 0)
        {
            turnLeft = true;
            turnRight = false;
        }
        else
        {
            turnLeft = false;
            turnRight = false;
        }
    }
}
