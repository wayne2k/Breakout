using UnityEngine;
using System.Collections;

namespace RollRoti.Breakout
{
	public class Bricks : MonoBehaviour 
	{
		public GameObject brickParticle;

		void OnCollisionEnter (Collision col)
		{
			Instantiate (brickParticle, transform.position, Quaternion.identity);
			GM.Instance.DestroyBrick ();
			Destroy (gameObject);
		}
	}
}