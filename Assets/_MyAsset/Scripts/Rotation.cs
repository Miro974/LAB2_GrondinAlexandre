using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    // Attributs
    [SerializeField] private float _vitesseRotaY = 0.5f;

    // Méthodes privées 
    private void Update()
    {
        transform.Rotate(0f, _vitesseRotaY, 0f);
    }
}
