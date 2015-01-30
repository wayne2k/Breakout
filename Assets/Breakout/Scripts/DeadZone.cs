using UnityEngine;
using System.Collections;

namespace RollRoti.Breakout
{
	public class DeadZone : MonoBehaviour 
	{
		void OnTriggerEnter (Collider other)
		{
			GM.Instance.LooseLife ();
		}
	}
}