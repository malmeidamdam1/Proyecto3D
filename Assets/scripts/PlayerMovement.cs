using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	Rigidbody player;
	float moveSpeed = 7;
	public Transform cam;
	private int saltosRestantes;
	private int saltosMaximos;
	private float distanciaSalto;


	// Start is called before the first frame update
	void Start()
	{
		player = GetComponent<Rigidbody>();
		saltosMaximos = 2;
		saltosRestantes = saltosMaximos;
		distanciaSalto = 8f;
	}

	// Update is called once per frame
	void Update()
	{
		ProcesarMovimiento();
		ProcesarSalto();
	}

	void ProcesarMovimiento()
	{
		// Inputs
		float horInput = Input.GetAxisRaw("Horizontal") * moveSpeed;
		float verInput = Input.GetAxisRaw("Vertical") * moveSpeed;

		// Camera dir
		Vector3 camForward = cam.forward;
		Vector3 camRight = cam.right;

		camForward.y = 0;
		camRight.y = 0;

		// Creating relate cam direction
		Vector3 forwardRelative = verInput * camForward;
		Vector3 rightRelative = horInput * camRight;

		// Movement
		Vector3 moveDir = forwardRelative + rightRelative;
		player.velocity = new Vector3(moveDir.x, player.velocity.y, moveDir.z);

		if (moveDir != Vector3.zero) //if para evitar la advertencia "look rotation...zero"
		{
			transform.forward = new Vector3(player.velocity.x, 0, player.velocity.z);
		}
	}

		void ProcesarSalto()
	{
		if (EstaEnSuelo())
		{
			saltosRestantes = saltosMaximos;
		}

		if ((EstaEnSuelo() && Input.GetKeyDown(KeyCode.Space) && saltosRestantes > 0))
		{
			saltosRestantes--;
			player.AddForce(Vector3.up * 5f, ForceMode.Impulse);
		}
	}


	bool EstaEnSuelo() 
	{
		
		return Physics.Raycast(transform.position, Vector3.down, distanciaSalto);
	}

}
