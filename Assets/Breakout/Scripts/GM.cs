using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace RollRoti.Breakout
{
	public class GM : MonoBehaviour 
	{
		public static GM Instance = null;

		public int lives = 3;
		public int bricks = 20;
		public float resetDelay = 1f;

		public Text livesText;
		public GameObject gameOver;
		public GameObject youWon;
		public GameObject bricksPfb;
		public GameObject paddlePfb;
		public GameObject deathParticles;

		GameObject _clonedPaddle;

		void Awake ()
		{
			if (Instance == null)
			{
				Instance = this;
			}
			else if (Instance != this)
			{
				Destroy (gameObject);
			}

			Setup ();
		}

		void CheckGameOver ()
		{
			if (bricks < 1)
			{
				youWon.SetActive (true);
				Time.timeScale = .25f;
				Invoke ("Reset", resetDelay);
			}

			if (lives < 1)
			{
				gameOver.SetActive (true);
				Time.timeScale = .25f;
				Invoke ("Reset", resetDelay);
			}
		}

		void Reset ()
		{
			Time.timeScale = 1f;
			Application.LoadLevel (Application.loadedLevel);
		}

		void SetupPaddle ()
		{
			_clonedPaddle = Instantiate (paddlePfb, transform.position, Quaternion.identity) as GameObject;
		}

		public void Setup ()
		{
			_clonedPaddle = Instantiate (paddlePfb, transform.position, Quaternion.identity) as GameObject;
			Instantiate (bricksPfb, transform.position, Quaternion.identity);
		}

		public void LooseLife ()
		{
			lives--;
			livesText.text = ("Lives: " + lives);

			Instantiate (deathParticles, _clonedPaddle.transform.position, Quaternion.identity);
			Destroy (_clonedPaddle);
			Invoke ("SetupPaddle", resetDelay);
			CheckGameOver ();
		}

		public void DestroyBrick ()
		{
			bricks--;
			CheckGameOver ();
		}
	}
}