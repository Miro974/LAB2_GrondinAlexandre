using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionCollision : MonoBehaviour
{
    // Attributs
    private bool _touche;
    private GestionJeu _gestionJeu;

    //Méthodes privées
    private void Start()
    {
        _gestionJeu = FindObjectOfType<GestionJeu>();
        _touche = false;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (!_touche && gameObject.tag != "FinNiveau")
            {
                _touche = true;
                gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
                _gestionJeu.AugmenterPointage();
            }
        }
        
    }
}
