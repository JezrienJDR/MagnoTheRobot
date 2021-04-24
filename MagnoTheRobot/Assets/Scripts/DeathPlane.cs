using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathPlane : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Magno m = collision.gameObject.GetComponent<Magno>();

        if(m != null)
        {
            m.transform.position = new Vector3(-70.6f, 54.42f, 299.32f);
        }
    }
}
