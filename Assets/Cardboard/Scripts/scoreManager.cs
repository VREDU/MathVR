using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class scoreManager : MonoBehaviour {
	public static int score;
	UnityEngine.UI.Text text;

	// Use this for initialization
	void Start () {
		text = GetComponent<Text>();
		score = 0;
	}

	// Update is called once per frame
	void Update () {
		if (Application.loadedLevel==1) {
			text.text = "There are 3 ships";
		}
		if (Application.loadedLevel==2){
		text.text = "There are 4 ships";
		}
	}
}
