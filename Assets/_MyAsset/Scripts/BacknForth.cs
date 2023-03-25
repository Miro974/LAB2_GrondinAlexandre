using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BacknForth : MonoBehaviour
{
    [SerializeField] float distance = 17;  // D�termine la distance et la vitesse du mouvement
    [SerializeField] float vitesse = 4;

    private Vector3 postionDepart;

    private void Start()
    {
        postionDepart = transform.position; // D�termine la position de d�part de l'objet
    }

    private void FixedUpdate()
    {
        BackNForth();   // Appel de la fonction
    }
    public void BackNForth()
    {
        Vector3 v = postionDepart;
        v.x += distance * Mathf.Sin(Time.time * vitesse);
        transform.position = v;
    }
}
