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
                Debug.Log("Fin de partie!!");
                _player.finJoueur();
            }
            else 
            {
                Debug.Log(numScene.ToString());
                SceneManager.LoadScene(numScene + 1);
            }
        }

    }
}
