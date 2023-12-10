using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public int PuntosTotales { get { return puntosTotales; } }

    private int puntosTotales;

    public HUD hud; //Asignamos en editor

    private int monedasTotales; //


    void Start()
    {
        // Inicializa el contador de monedas con la cantidad total de monedas en el nivel.
        monedasTotales = GameObject.FindGameObjectsWithTag("coin").Length;
    }

     void Update()
    {
        Debug.Log("MONEDAS: " + monedasTotales);
        if (puntosTotales == monedasTotales)
        {
            Debug.Log("FIN JUEGO");
           // SceneManager.LoadScene(1); //
        }
    }

    public void SumarPuntos(int puntosSumar)
    {
        puntosTotales += puntosSumar;
        hud.ActualizarPuntos(puntosTotales);
        if (puntosTotales == monedasTotales) 
        {
            SceneManager.LoadScene(1); //Cargar escena con mensajeGanador
        }
    }


}
