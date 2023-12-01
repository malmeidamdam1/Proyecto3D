using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform Player;
	float MouseSpeed = 3;
	float orbitDamping = 10;
	Vector3 localRot;

    // Start is called before the first frame update
    void Start()
    {
		
    }
	
	void Update()
	{
		transform.position = Player.position;
		
		localRot.x += Input.GetAxis("Mouse X") * MouseSpeed;
		localRot.y -= Input.GetAxis("Mouse Y") * MouseSpeed;
		
		localRot.y = Mathf.Clamp(localRot.y, 20f, 60f); //Normaliza valores a min y max
			
		Quaternion QT = Quaternion.Euler(localRot.y, localRot.x, 0f);
		transform.rotation = Quaternion.Lerp(transform.rotation, QT, Time.deltaTime * orbitDamping);
	}
}
