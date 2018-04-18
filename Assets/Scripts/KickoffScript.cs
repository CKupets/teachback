using UnityEngine;
using System.Collections;

public class KickoffScript : MonoBehaviour {
	
	int score = 0;
	int highscore = 0;
	
	void Start () {
		highscore = PlayerPrefs.GetInt ("HighScore");
	}
	
	void OnGUI()
	{
		GUI.Label (new Rect (Screen.width / 2 - 40, 200, 200, 30), "Start the Game");
		
		GUI.Label (new Rect (Screen.width / 2 - 40, 230, 200, 30), "High Score: " + highscore);
		if (GUI.Button (new Rect (Screen.width / 2 - 30, 260, 60, 30), "START")) {
			Application.LoadLevel (1);
		}
	}
}
