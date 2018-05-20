using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakableWallScript : MonoBehaviour {
	public PlayerController thePlayer;
	public Animator anim;

	public DoorController theDoor;

	public bool wallBroken;

	public AudioClip breakWall;
	// Use this for initialization
	void Start () {
		wallBroken = false;
		anim = GetComponent<Animator> ();
		thePlayer = FindObjectOfType<PlayerController> ();
		theDoor = FindObjectOfType<DoorController> ();
		anim.SetBool("isWallBroken", false);
		theDoor.anim.SetBool ("DoorOpen", false);
	}
	
	// Update is called once per frame
	void Update () {
		//thePlayer = FindObjectOfType<PlayerController> ();
	}

	void OnTriggerStay2D(Collider2D other){

		if (Input.GetKey("e") && thePlayer.isSpriteFrank){
			//knock down
			anim.SetBool("isWallBroken", true);
			wallBroken = true;

			Physics2D.IgnoreCollision (thePlayer.GetComponent<BoxCollider2D> (), GetComponent<BoxCollider2D> (), true);

			theDoor.anim.SetBool ("DoorOpen", true);
			//add sound here 
			SoundManager.instance.PlaySingle(breakWall);
		}
	}
}
