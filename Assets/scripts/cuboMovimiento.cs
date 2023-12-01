using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cuboMovimiento : MonoBehaviour
{
    public Rigidbody cubo;

    private void Start()
    {
        cubo = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        
        float inputMovimiento = Input.GetAxis("Horizontal");
        if (inputMovimiento != 0f) 
        {
            cubo.velocity = new Vector2(inputMovimiento * 1, cubo.velocity.y);
        }

        float inputMovimientoVertical = Input.GetAxis("Vertical");
        if (inputMovimientoVertical != 0f)
        {
            cubo.velocity = new Vector3(cubo.velocity.x, cubo.velocity.y,inputMovimientoVertical*1);
        }


        if (Input.GetKeyDown(KeyCode.Space))
        {
            cubo.AddForce(Vector3.up * 5f, ForceMode.Impulse);
        }


    }


}
