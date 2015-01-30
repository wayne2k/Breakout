using UnityEngine;
using System.Collections;

namespace RollRoti.Breakout
{
	public class Paddle : MonoBehaviour
	{
		public float paddleSpeed = 1f;

		Vector3 playerPos = new Vector3 (0f, -9.5f, 0f);

		void Update ()
		{
			float xPos = transform.position.x + (Input.GetAxis ("Horizontal") * paddleSpeed * Time.deltaTime);

			playerPos = new Vector3 (Mathf.Clamp (xPos, -8f, 8f), -9.5f, 0f);

			transform.position = playerPos;
		}
	}
}