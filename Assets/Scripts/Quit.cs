using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey ("q")) {
			QuitGame();
		}
	}

	public void QuitGame(){
		Debug.Log ("player has quit the game");
		Application.Quit ();
	}
}
