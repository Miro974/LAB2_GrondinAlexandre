using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBarriere : MonoBehaviour
{
    // Attributs
    [SerializeField] private GameObject _barriere = new GameObject();

    //Méthodes privées

    // Fonction qui déclenche la destruction des barrières du troisième niveau si les objectifs sont touchés par le joueur
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {

            _barriere.GetComponent<GestionBarriere>().BarriereDestroy();
        }

    }
}
