using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

using UnityEngine;

public class DoorController : MonoBehaviour {
	//public string levelToLoad;
	public PlayerController thePlayer;

	public Animator anim;
	//public LevelUnlockController LevelUnlock;
	public bool unlocked;

	// Use this for initialization
	void Start () {
		thePlayer = FindObjectOfType<PlayerController> ();
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		//LevelUnlock = FindObjectOfType<LevelUnlockController>();
	}

	void OnTriggerEnter2D(Collider2D other){
		Debug.Log("SCENE SHOULD CHANGE, entered trigger");
		//if (unlocked == true) {
		if (thePlayer.isSpriteHuman) {//&& thePlayer.isSpriteHuman
			Debug.Log("SCENE SHOULD CHANGE");
				//make this more generic
				//SceneManager.LoadScene (levelToLoad);
			SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex+1);
		}
		//}
	}
		
}
