using UnityEngine;
using System.Collections;

public class GameOverScript : MonoBehaviour {

	int score = 0;
	int highscore = 0;
	
	void Start () {
		score = PlayerPrefs.GetInt ("Score");
		highscore = PlayerPrefs.GetInt ("HighScore");
	}

	void OnGUI()
	{
		GUI.Label (new Rect (Screen.width / 2 - 40, 50, 80, 30), "GAME OVER");

		GUI.Label (new Rect (Screen.width / 2 - 40, 200, 80, 30), "Score: " + score);
		GUI.Label (new Rect (Screen.width / 2 - 40, 230, 200, 30), "High Score: " + highscore);
		if (GUI.Button (new Rect (Screen.width / 2 - 30, 260, 60, 30), "Retry?")) {
			Application.LoadLevel (1);
		}
	}
}
