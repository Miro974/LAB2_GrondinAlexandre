using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionBarriere : MonoBehaviour
{
    // Fonction qui détruit les barrières du troisième niveau
    public void BarriereDestroy()
    { 
        gameObject.SetActive(false);
    }
}
