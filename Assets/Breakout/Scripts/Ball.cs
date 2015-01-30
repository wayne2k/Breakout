using UnityEngine;
using System.Collections;

namespace RollRoti.Breakout
{
	public class Ball : MonoBehaviour 
	{
		public float ballInitialVelocity = 600f;

		bool _ballInPlay;
		Rigidbody _rb;

		void Awake ()
		{
			_rb = GetComponent <Rigidbody> ();
		}

		void Update ()
		{
			if (Input.GetButtonDown ("Fire1") && _ballInPlay == false)
			{
				transform.parent = null;
				_ballInPlay = true;
				_rb.isKinematic = false;
				_rb.AddForce (new Vector3 (ballInitialVelocity, ballInitialVelocity, 0f));
			}
		}
	}
}