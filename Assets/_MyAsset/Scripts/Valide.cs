using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Valide : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GetComponent<MeshRenderer>().material.color = Color.green;
        }
    }
    
}
