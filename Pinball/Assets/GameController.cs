using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GameController : MonoBehaviour
{

	#region Fields

	public Plunger Plunger;
	public BallBehavior Ball;
	public static GameController Instance;
	public FlipperBehavior LeftFlipper;
	public FlipperBehavior RightFlipper;

	#endregion

	// Start is called before the first frame update
	void Start()
	{
		GameController.Instance = this;

		

	}

	// Update is called once per frame
	void Update()
	{

		HandleFlippers();

	}

	private void HandleFlippers()
	{

		if (Input.GetKey(KeyCode.LeftShift))
		{
			LeftFlipper.Flip();
		} else {
			LeftFlipper.Unflip();
		}
		if (Input.GetKey(KeyCode.RightShift))
		{
			RightFlipper.Flip();
		} else {
			RightFlipper.Unflip();
		}


	}

	/// <summary>
	/// Method to be called to indicate that the turn has ended
	/// </summary>
	public void EndTurn() {

		// do stuff
		Ball.ResetPosition();


	}



}
