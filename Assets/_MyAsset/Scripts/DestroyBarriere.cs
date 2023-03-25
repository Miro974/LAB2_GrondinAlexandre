using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBarriere : MonoBehaviour
{
    // Attributs
    [SerializeField] private GameObject _barriere = new GameObject();

    //M�thodes priv�es


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {

            _barriere.GetComponent<GestionBarriere>().BarriereDestroy();
        }

    }
}
