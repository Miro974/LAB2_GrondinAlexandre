using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ZonePiege : MonoBehaviour
{
    // Attributs
    private bool _actif = false;
    [SerializeField] private List<GameObject> _listePieges = new List<GameObject>();
    private List<Rigidbody> _listeRb = new List<Rigidbody>();
    [SerializeField] private float _intensiteForce = 300;


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
                foreach (var piege in _listePieges)
                { 
                    switch (piege.tag)
                    {
                        case "PiegeD": Vector3 directionD = new Vector3(-2f, -1f, 0f);
                                       piege.GetComponent<Rigidbody>().AddForce(directionD * _intensiteForce);
                                       
                                       

                        break;
                        case "PiegeG": Vector3 directionG = new Vector3(2f, -1f, 0f);
                                       piege.GetComponent<Rigidbody>().AddForce(directionG * _intensiteForce);
                                       
                                      
                        break;
                        case "SphereG": _intensiteForce = 500;
                                        Vector3 directionSG = new Vector3(0.5f, -1f, 0f);
                                        piege.GetComponent<Rigidbody>().AddForce(directionSG * _intensiteForce);
                            
                        break;
                        case "SphereD": _intensiteForce = 500;
                                        Vector3 directionSD = new Vector3(-0.5f, -1f, 0f);
                                        piege.GetComponent<Rigidbody>().AddForce(directionSD * _intensiteForce);
                            

                        break;

                    }
                   rb.useGravity = true;
                }
            }
            _actif = true;
        }
    }


    

}
