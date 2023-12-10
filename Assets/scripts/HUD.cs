using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HUD : MonoBehaviour
{
    public GameManager gameManager;
    public TextMeshProUGUI puntos;
    public TextMeshProUGUI monedasTotales;


     void Start()
    {
        monedasTotales.text = GameObject.FindGameObjectsWithTag("coin").Length.ToString();
    }

    public void ActualizarPuntos(int puntosTotales)
    {
        puntos.text = puntosTotales.ToString();
    }

}
