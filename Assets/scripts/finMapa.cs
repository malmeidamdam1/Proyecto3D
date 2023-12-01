using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finMapa : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform respawn_point;
    private float tiempoEspera = 0.5f;

    //Asiganamos en editor

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Invoke("MoverAlRespawn", tiempoEspera);
        }
    }

    private void MoverAlRespawn()
    {
        player.transform.position = respawn_point.transform.position;
    }


}
