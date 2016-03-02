using UnityEngine;
using System.Collections;

public class GameOverManager : MonoBehaviour {

	public scoreManager scoreManager;
	public static bool gameOver;
	public GameObject playAgain;
	Animator anim;



	void Start()
	{
		anim = GetComponent<Animator>();
		gameOver = false;
	}
	void Update () {
		if (gameOver) {
			if (scoreManager.score == 3 && Application.loadedLevel == 1) {
				anim.SetTrigger ("Winner");
				playAgain.SetActive (true);
			} 
			if (scoreManager.score == 4 && Application.loadedLevel == 2) {
				anim.SetTrigger ("Winner");
				playAgain.SetActive (true);
			}
			else {
				anim.SetTrigger ("Loser");
				playAgain.SetActive (true);
			}
		}
	}
}
