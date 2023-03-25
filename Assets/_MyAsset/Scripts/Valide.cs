using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Valide : MonoBehaviour
{
    // Changer la couleur des objectifs pour montrer qu'ils ont bien été validés
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GetComponent<MeshRenderer>().material.color = Color.green;
        }
    }
    
}
