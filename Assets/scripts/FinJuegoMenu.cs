using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinJuegoMenu : MonoBehaviour
{
    //Asignan en editor desde button list
    public void Rejugar()
    {
        //Recarga nivel
        SceneManager.LoadScene(0);
    }
    public void salir()
    {
        //Cierra 
        Debug.Log("Gracias por jugar");
        Application.Quit();
    }

}
