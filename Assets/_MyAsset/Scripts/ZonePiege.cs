using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZonePiege : MonoBehaviour
{
    // Attributs
    [SerializeField] private GameObject _piege = default;
    private Rigidbody _rb;
    private Transform _transform;
    private bool FinNiveau; 

    // Méthodes privées
    private void Start()
    {
        _rb = _piege.GetComponent<Rigidbody>();
        _rb.useGravity = false;
        _transform = _piege.transform;
        FinNiveau = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        _rb.useGravity = true;
        UpnDown();
    }

    private void UpnDown()
    {
        if (_rb.useGravity)
        { 
            while(!FinNiveau)
                _transform.position.Set(85.06605f, -0.55163f, -35.3218f);
        }
            
        
    }



}
