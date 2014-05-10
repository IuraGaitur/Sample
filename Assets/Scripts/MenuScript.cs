using UnityEngine;
using System.Collections;

public class MenuScript : MonoBehaviour
{
	private GUISkin skin;
	
	void Start()
	{
		// Load a skin for the buttons
		skin = Resources.Load("play_Button") as GUISkin;
	}

	void OnGUI()
	{
		const int buttonWidth = 60;
		const int buttonHeight = 30;

		GUI.skin = skin;

		if (
			GUI.Button(
			// Center in X, 1/3 of the height in Y
			new Rect(
			Screen.width / 4 -(buttonWidth / 2),
			(2 * Screen.height / 3) - (buttonHeight / 2),
			buttonWidth,
			buttonHeight
			),
			"Play!"
			)
			)
		{
			// Reload the level
			Application.LoadLevel("Gameplay");
		}
		
		if (
			GUI.Button(
			// Center in X, 2/3 of the height in Y
			new Rect(
			Screen.width / 2 - (buttonWidth)-10,
			(2 * Screen.height / 3) - (buttonHeight / 2),
			buttonWidth,
			buttonHeight
			),
			"Options"
			)
			)
		{
			// Reload the level
			Application.LoadLevel("Options");
		}

		if (
			GUI.Button(
			// Center in X, 2/3 of the height in Y
			new Rect(
			Screen.width / 2 + (buttonWidth/4) ,
			(2 * Screen.height / 3) - (buttonHeight / 2),
			buttonWidth+20,
			buttonHeight
			),
			"High Score"
			)
			)
		{
			// Reload the level
			Application.LoadLevel("HighScore");
		}


		if (
			GUI.Button(
			// Center in X, 2/3 of the height in Y
			new Rect(
			Screen.width / 2 +(2*buttonWidth),
			(2 * Screen.height / 3) - (buttonHeight / 2),
			buttonWidth,
			buttonHeight
			),
			"Exit"
			)
			)
		{
			// Reload the level
			Application.Quit();
		}

	}



}
