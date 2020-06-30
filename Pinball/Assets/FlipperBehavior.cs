using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipperBehavior : MonoBehaviour
{

	private Quaternion _StartRotation;
	public bool FlipClockwise = false;
	public float MaximumRotationDegrees = 30;
	private bool _StopTheFlop = true;


	// Start is called before the first frame update
	void Start()
	{
		_StartRotation = transform.rotation;
	}

	// Update is called once per frame
	void Update()
	{

	}

	public void OnCollisionEnter(Collision collision)
	{

		if (collision.collider.gameObject.name == "Ball")
		{

			var pinball = collision.collider.attachedRigidbody;
			//pinball.AddRelativeForce(0, 0, (_ReleaseDistance / MaxPullDistance) * MaxPlungerForce, ForceMode.Impulse);
			pinball.AddRelativeForce(0, 0, 5, ForceMode.Impulse);


		}

	}

	public void Flip()
	{

		var angle = Vector3.Angle(_StartRotation.eulerAngles, transform.rotation.eulerAngles);
		Debug.Log($"Flipper has flipped {angle} degrees");
		if (Mathf.Abs(angle) > MaximumRotationDegrees) return;

		transform.Rotate(0, ((FlipClockwise ? 1 : -1) * 3), 0);
		_StopTheFlop = false;

	}

	public void Unflip()
	{

		if (_StopTheFlop) return;

		var angle = Vector3.Angle(_StartRotation.eulerAngles, transform.rotation.eulerAngles);
		if (Mathf.Abs(angle) == 0)
		{
			_StopTheFlop = true;
			return;
		}
		transform.Rotate(0, ((FlipClockwise ? -1 : 1) * 3), 0);
	}
}
