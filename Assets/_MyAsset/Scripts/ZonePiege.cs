using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZonePiege : MonoBehaviour
{
    // Attributs
    [SerializeField] private GameObject _piege = default;
    private Rigidbody _rb;


    // Méthodes privées
    private void Start()
    {
        _rb = _piege.GetComponent<Rigidbody>();
        _rb.useGravity = false;

    }
    private void OnTriggerEnter(Collider other)
    {
        _rb.useGravity = true;
    }




}
