using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class Restart : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey ("r")) {
			RestartGame ();
		}
	}

	public void RestartGame(){
		Debug.Log ("Scene shoud restart! button clicked!");
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
	}
}
