using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionBarriere : MonoBehaviour
{
    public void BarriereDestroy()
    { 
        gameObject.SetActive(false);
    }
}
