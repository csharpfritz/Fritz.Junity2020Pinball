using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipperBehavior : MonoBehaviour
{

	private Quaternion _StartRotation;

	// Start is called before the first frame update
	void Start()
	{
		_StartRotation = transform.rotation;
	}

	// Update is called once per frame
	void Update()
	{

	}

	public void Flip()
	{

		transform.Rotate(0, 3, 0);

	}

}
