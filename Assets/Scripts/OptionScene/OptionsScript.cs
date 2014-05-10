using UnityEngine;
using System.Collections;

public class OptionsScript : MonoBehaviour {

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
			GUI.Button (
			// Center in X, 1/3 of the height in Y
			new Rect (
			Screen.width / 4 - (buttonWidth / 2),
			(2 * Screen.height / 4) - (buttonHeight / 2),
			buttonWidth,
			buttonHeight
				),
			"With Sound"
				)
			) {
						
						// Reload the level
						Application.LoadLevel ("Start_Game");
				}
		if (
			GUI.Button (
			// Center in X, 1/3 of the height in Y
			new Rect (
			Screen.width / 4 - (buttonWidth / 2),
			(2 * Screen.height / 4) - (buttonHeight / 2),
			buttonWidth,
			buttonHeight
			),
			"No Sound"
			)
			) {
			// Reload the level
			Application.LoadLevel ("Start_Game");
		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
