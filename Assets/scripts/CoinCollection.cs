using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollection : MonoBehaviour
{
    private int valor = 1;
    public GameManager gameManager;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player") 
        {
            gameManager.SumarPuntos(valor);
            Destroy(this.gameObject);
        }
    }
}
