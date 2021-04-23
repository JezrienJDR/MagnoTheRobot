using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetalItem : MonoBehaviour
{
    public float mass;
    private Material mat;
    public MeshRenderer mesh;
    private Rigidbody rb;
    private bool isTarget;
    private int id;

    // Start is called before the first frame update
    void Start()
    {

        mat = GetComponent<MeshRenderer>().material;

        if (mat == null)
        {
            mat = mesh.material;
        }

        id = Random.Range(1, 9001);
        rb = GetComponent<Rigidbody>();

        mass = rb.mass;
    }

    private void Awake()
    {

        mat = GetComponent<MeshRenderer>().material;

        if (mat == null)
        {
            mat = mesh.material;
        }

        id = Random.Range(1, 9001);
        rb = GetComponent<Rigidbody>();

        mass = rb.mass;
    }

    public int GetID()
    {
        return id;
    }
    public float GetMass()
    {
        return mass;
    }

    public void ApplyForce(Vector3 f)
    {
        rb.AddForce(f);
    }

    public void ShowGlow()
    {
        //Debug.Log(isTarget);
        if(!isTarget)
        {
            //Debug.Log("GLOWING UP");
            isTarget = true;
            //Debug.Log(isTarget);
            StartCoroutine("GlowUp");
        }
    }
    public void FadeGlow()
    {
        isTarget = false;
        StartCoroutine("GlowDown");
    }



    IEnumerator GlowUp()
    {    
        for(int i = 0; i < 21; i++)
        {
            mat.SetFloat("_Glow", i * 0.05f);
            yield return new WaitForSeconds(0.01f);
        }
    }
    IEnumerator GlowDown()
    {
        for (int i = 20; i > -1; i--)
        {
            mat.SetFloat("_Glow", i * 0.05f);
            yield return new WaitForSeconds(0.01f);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
