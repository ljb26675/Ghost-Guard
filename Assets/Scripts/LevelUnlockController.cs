using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelUnlockController : MonoBehaviour {
	public bool unlocked = false;

	public DoorController Door;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Door = FindObjectOfType<DoorController> ();
		Door.anim.SetBool ("DoorOpen", false);
	}

	//not needed anymore, door does not need to be unlocked, just reached by the human
	void OnTriggerEnter2D(Collider2D other){
		//if press a button, pick it up, like i or e
		if (other.tag == "Player") {
			Door.anim.SetBool ("DoorOpen", false);
			Door.unlocked = true;
			//Door.anim.SetBool ("DoorOpen", true);
			Destroy (gameObject);
			//gameObject.SetActive (false);
		}
	}
}
