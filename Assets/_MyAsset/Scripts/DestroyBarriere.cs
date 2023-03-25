using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBarriere : MonoBehaviour
{
    // Attributs
    [SerializeField] private GameObject _barriere = new GameObject();

    //Méthodes privées


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {

            _barriere.GetComponent<GestionBarriere>().BarriereDestroy();
        }

    }
}
