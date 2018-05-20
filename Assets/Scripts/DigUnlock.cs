using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DigUnlock : MonoBehaviour {
	public PlayerController thePlayer;
	public SpriteRenderer theSpriteRenderer;
	public DoorController Door;

	public LevelManager theLevelManager;

	public Transform startPoint;
	public Transform endPoint;

	private Vector3 currentTarget;

	public bool isShovelActive;

	public AudioClip digging;


	// Use this for initialization
	void Start () {
		thePlayer = FindObjectOfType<PlayerController> ();
		theSpriteRenderer = GetComponent<SpriteRenderer> ();
		Door = FindObjectOfType<DoorController> ();
		theLevelManager = FindObjectOfType<LevelManager> ();

		Door.anim.SetBool ("DoorOpen", false);
		isShovelActive = true;

	}
	
	// Update is called once per frame
	void Update () {
		currentTarget = endPoint.position;
	}

	void OnTriggerStay2D(Collider2D other){
		Debug.Log ("Entered lever trigger");

		if (Input.GetKey ("e") && thePlayer.isSpriteWere) {
			//get rid of b
			isShovelActive =false;

			Debug.Log ("Player digging");
			Door.unlocked = true;

			Door.anim.SetBool ("DoorOpen", true);
			//DESTROY THE SHOVEL
			//theSpriteRenderer.enabled = false;

			//theLevelManager.Poof ();
			thePlayer.gameObject.SetActive (false);

			thePlayer.gameObject.transform.position = endPoint.position;

			thePlayer.gameObject.SetActive (true);
			thePlayer.anim.SetBool("isFrank", false);
			thePlayer.anim.SetBool ("isPlayer", false);
			thePlayer.anim.SetBool ("isSkele", false);
			thePlayer.anim.SetBool ("isWere", true);
			thePlayer.anim.SetBool ("isHuman", false);



			//add sound here 
			SoundManager.instance.PlaySingle(digging);
		}
	}


}
