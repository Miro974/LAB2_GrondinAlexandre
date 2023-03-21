using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BacknForth : MonoBehaviour
{
    [SerializeField] float distance = 17;
    [SerializeField] float vitesse = 4;

    private Vector3 postionDepart;
    private void Start()
    {
        postionDepart = transform.position;
    }

    private void FixedUpdate()
    {
        BackNForth();
    }

    public void BackNForth()
    {
        Vector3 v = postionDepart;
        v.x += distance * Mathf.Sin(Time.time * vitesse);
        transform.position = v;
    }
}
