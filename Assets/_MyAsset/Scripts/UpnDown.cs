using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpnDown : MonoBehaviour
{
    [SerializeField] float distance;
    [SerializeField] float vitesse;

    private Vector3 postionDepart;
    private void Start()
    {
        postionDepart = transform.position;
    }

    private void FixedUpdate()
    {
        UpNDown();
    }

    public void UpNDown()
    {
        Vector3 v = postionDepart;
        v.y += distance * Mathf.Sin(Time.time * vitesse);
        transform.position = v;
    }
}
