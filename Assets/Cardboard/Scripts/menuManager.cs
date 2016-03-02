using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menuManager : MonoBehaviour {
	void Start ()
	{
		GazedAt(false);
	}

	public void StartLevel()
	{
		SceneManager.LoadScene(1);
	}

	public void StartAgain()
	{
		SceneManager.LoadScene(0);
	}


	public void Level()
	{
		SceneManager.LoadScene(2);
	}

	public void GazedAt(bool gazedAt)
	{
		GetComponent<Image>().color = gazedAt ? Color.green : Color.red;
	}

	public void GazedAtInt(bool gazedAt)
	{
		if(!GameOverManager.gameOver)
			GetComponent<Image>().color = gazedAt ? Color.blue : Color.grey;
	}

	public void selectNumber()
	{
		GetComponent<Image>().color = Color.cyan;
		scoreManager.score = GetComponent<numberManager>().buttonValue;
		GameOverManager.gameOver = true;


	}
}
