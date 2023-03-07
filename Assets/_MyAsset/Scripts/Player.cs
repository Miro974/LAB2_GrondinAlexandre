using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //Attributs
    [SerializeField] private float _vitesse = 10f;
    private Rigidbody _rb;

    //Méthodes privées
    private void Start()
    {
        //Position initiale du joueur
        transform.position = new Vector3(0f, 0.51f, -45f);
        _rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        MouvementJoueur();
    }

    private void MouvementJoueur()
    {
        float posX = Input.GetAxis("Horizontal");
        float posZ = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(posX, 0f, posZ);
        direction.Normalize();
        //transform.Translate(direction * Time.deltaTime * _vitesse);
        _rb.velocity = direction * Time.fixedDeltaTime * _vitesse;
    }

}