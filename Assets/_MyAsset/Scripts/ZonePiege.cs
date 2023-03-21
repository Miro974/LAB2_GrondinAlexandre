using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZonePiege : MonoBehaviour
{
    // Attributs
    private bool _actif = false;
    [SerializeField] private List<GameObject> _listePieges = new List<GameObject>();
    private List<Rigidbody> _listeRb = new List<Rigidbody>();
    [SerializeField] private float _intensiteForce = 200;


    // Méthodes privées
    private void Start()
    {
        foreach (var piege in _listePieges)
        {
            _listeRb.Add(piege.GetComponent<Rigidbody>());
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && !_actif)
        {
            foreach (var rb in _listeRb)
            {
                rb.useGravity = true;
                Vector3 direction = new Vector3(-1f, -1f, 0f);
                rb.AddForce(direction * _intensiteForce);
            }

            _actif = true;
        }
    }




}
