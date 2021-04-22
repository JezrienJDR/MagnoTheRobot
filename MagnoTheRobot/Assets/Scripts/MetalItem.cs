using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetalItem : MonoBehaviour
{
    public float mass;
    private Material mat;


    // Start is called before the first frame update
    void Start()
    {
        mat = GetComponent<MeshRenderer>().material;
    }

    public void ShowGlow()
    {
        StartCoroutine("GlowUp");
    }
    public void FadeGlow()
    {
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
        for (int i = 20; i > 0; i--)
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
