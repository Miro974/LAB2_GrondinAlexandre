using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinNiveau : MonoBehaviour
{
    // Attributs
    private bool _finJeu = false;
    private GestionJeu _gestionJeu;
    private Player _player;

    //Méthodes privées
    private void Start()
    {
        _gestionJeu = FindObjectOfType<GestionJeu>();
        _player = FindObjectOfType<Player>();
    }

    private void Update()
    {
        if (_finJeu)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            { 
                Application.Quit();
            }
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player" && !_finJeu)
        {
            GetComponent<MeshRenderer>().material.color = Color.green;
            _finJeu = true;

            //Récupérer index de la scène
            int numScene = SceneManager.GetActiveScene().buildIndex;
            if (numScene == 2)
            {
                int contacts = _gestionJeu.GetPointage();
                // Temps + pénalités Niveau 1
                //float tpsNiv1 = Time.time - _gestionJeu.GetTpsNiv1();
                float tpsTotalNiv1 = _gestionJeu.GetTpsNiv1() + _gestionJeu.GetContactNiv1();
                // Temps + pénalités Niveau 2
                float tpsNiv2 = Time.time - _gestionJeu.GetTpsNiv1();
                int contactNiv2 = _gestionJeu.GetPointage() - _gestionJeu.GetContactNiv1();
                //Debug.Log(_gestionJeu.GetPointage().ToString());
                //Debug.Log(_gestionJeu.GetContactNiv1().ToString());
                //Debug.Log((_gestionJeu.GetPointage() - _gestionJeu.GetContactNiv1()).ToString());
                float tpsTotalNiv2 = tpsNiv2 + contactNiv2;
                // Temps + pénalités Niveau 3
                float tpsNiv3 = Time.time - (_gestionJeu.GetTpsNiv1() + tpsNiv2);
                int contactNiv3 = _gestionJeu.GetPointage() /*- (_gestionJeu.GetContactNiv1() + contactNiv2)*/;
                float tpsTotalNiv3 = tpsNiv3 + contactNiv3;

                // Bilan de fin de partie
                Debug.Log("Fin de partie!!");
                // Niveau 1
                Debug.Log("Votre temps pour le niveau 1 est de : " + _gestionJeu.GetTpsNiv1().ToString("f2") + " secondes");
                Debug.Log("Au niveau 1 vous avez touché : " + _gestionJeu.GetContactNiv1().ToString() + " obstacles");
                Debug.Log("Temps total du niveau 1 : " + tpsTotalNiv1.ToString("f2") + " secondes");
                // Niveau 2
                Debug.Log("Votre temps pour le niveau 2 est de : " + tpsNiv2.ToString("f2") + " secondes");
                Debug.Log("Au niveau 2 vous avez touché : " + contactNiv2.ToString() + " obstacles");
                Debug.Log("Temps total du niveau 2 : " + tpsTotalNiv2.ToString("f2") + " secondes");
                // Niveau 3
                Debug.Log("Votre temps pour le niveau 3 est de : " + tpsNiv3.ToString("f2") + " secondes");
                Debug.Log("Au niveau 3 vous avez touché : " + contactNiv3.ToString() + " obstacles");
                Debug.Log("Temps total du niveau 3 : " + tpsTotalNiv3.ToString("f2") + " secondes");

                Debug.Log("Votre temps total pour les trois niveaux est de : " + (tpsTotalNiv1 + tpsTotalNiv2).ToString("f2"));
                _player.finJoueur();
            }
            else
            {
                // Charger la scène suivante
                
                    _gestionJeu.SetNiv1(_gestionJeu.GetPointage(), Time.time);
                    //Debug.Log(_gestionJeu.GetContactNiv1().ToString());
                
                    _gestionJeu.SetNiv2((_gestionJeu.GetPointage() - _gestionJeu.GetContactNiv1()), (Time.time - _gestionJeu.GetTpsNiv1()));


                SceneManager.LoadScene(numScene + 1);
            }
            
        }

    }
}
