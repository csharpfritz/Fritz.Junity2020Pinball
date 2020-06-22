using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plunger : MonoBehaviour
{

	public float PullSpeed;

	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{

		HandlePlunger();

	}

	private void HandlePlunger()
	{

		if (Input.GetKey(KeyCode.DownArrow))
		{

			transform.position -= transform.up * PullSpeed * Time.deltaTime;

		}


	}

}
