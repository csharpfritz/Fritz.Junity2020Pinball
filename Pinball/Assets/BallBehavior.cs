using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BallBehavior : MonoBehaviour
{

	private Vector3 _StartPosition;


	// Start is called before the first frame update
	void Start()
	{

		_StartPosition = transform.position;

	}

	private void OnCollisionEnter(Collision collision)
	{

		if (collision?.collider.gameObject.name  == "GutterCatch")
		{
			GameController.Instance.EndTurn();
		}

	}

	// Update is called once per frame
	void Update()
	{

	}

	/// <summary>
	/// Move the ball back to the starting position, preparing for a new turn
	/// </summary>
	public void ResetPosition() {

		transform.position = _StartPosition;
		GetComponent<Rigidbody>().velocity = Vector3.zero;
		GetComponent<Rigidbody>().rotation.Set(0, 0, 0, 0);

	}

}
