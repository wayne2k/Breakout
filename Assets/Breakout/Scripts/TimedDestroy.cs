using UnityEngine;
using System.Collections;

namespace RollRoti.Breakout
{
	public class TimedDestroy : MonoBehaviour 
	{
		public float destroyTime = 1f;

		void Start ()
		{
			Destroy (gameObject, destroyTime);
		}
	}
}