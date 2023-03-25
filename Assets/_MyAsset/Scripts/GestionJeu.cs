using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionJeu : MonoBehaviour
{
    // Attributs
    private int _pointage = 0;
    private int _contactNiv1 = 0;
    private int _contactNiv2 = 0;
    private float _tpsNiv1 = 0.0f;
    private float _tpsNiv2 = 0.0f;

    // Métodes privées
    private void Start()
    {
        InstructionDepart();
    }
    private void Awake()
    {
        int nbGestionJeu = FindObjectsOfType<GestionJeu>().Length;  // Fonctionne qui détermine si l'on garde ou non les inforamtions d'une scène
        if (nbGestionJeu > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    public static void InstructionDepart()
    {
        Debug.Log("*** Course d'obstacles ***");
        Debug.Log("But du jeu: Atteindre la fin du niveau le plus rapidement possible.");
        Debug.Log("Chaque contact avec un obstacle entraînera une pénalité d'une seconde.");
    }

    // Méthodes publiques

    // Fonctions pour récupérer divers informations liées à chacun des niveaux
    public void AugmenterPointage()
    {
        _pointage++;
    }

    public int GetPointage()
    { 
        return _pointage;
    }

    public int GetContactNiv1()
    {
        return _contactNiv1;
    }

    public float GetTpsNiv1()
    { 
        return _tpsNiv1;
    }

    public int GetContactNiv2()
    {
        return _contactNiv2;
    }

    public float GetTpsNiv2()
    {
        return _tpsNiv2;
    }

    public void SetNiv1(int contacts, float tpsNiv1)
    { 
        _contactNiv1 = contacts;
        _tpsNiv1 = tpsNiv1; 
    }

    public void SetNiv2(int contacts, float tpsNiv2)
    {
        _contactNiv2 = contacts;
        _tpsNiv2 = tpsNiv2;
    }
}
