using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
	public Transform respawnPoint;
	private Rigidbody rb;

	// Start is called before the first frame update
	void Start()
    {
		rb = GetComponent<Rigidbody>();
	}
	
	private void Update()
	{
		if (transform.position.y < -5)
		{
			Respawn();
		}
	}

	void Respawn()
	{
		rb.velocity = Vector3.zero;
		rb.angularVelocity = Vector3.zero;
		rb.Sleep();
		transform.position = respawnPoint.position;


	}
}
