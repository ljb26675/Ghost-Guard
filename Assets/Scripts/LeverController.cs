using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverController : MonoBehaviour {
	public PlayerController thePlayer;
	public BlockController theBlock;
	public SpriteRenderer theSpriteRenderer;
	public DoorController Door;

	public bool isLeverActive;

	public Sprite leverIsHit;
	public Sprite leverIsNotHit;

	public AudioClip leverDoorOpen;



	// Use this for initialization
	void Start () {
		theBlock = FindObjectOfType<BlockController> ();
		thePlayer = FindObjectOfType<PlayerController> ();
		theSpriteRenderer = GetComponent<SpriteRenderer> ();
		Door = FindObjectOfType<DoorController> ();

		isLeverActive = false;
		Door.anim.SetBool ("DoorOpen", false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerStay2D(Collider2D other){
		Debug.Log ("Entered lever trigger");

		if (Input.GetKey("e") && thePlayer.isSpriteSkele && isLeverActive == false){
			//get rid of block
			Debug.Log("Press lever");
			//Door.anim.SetBool ("DoorOpen", true);
			Door.unlocked = true;
			theSpriteRenderer.sprite = leverIsHit;
			theBlock.gameObject.SetActive (false);


			Door.anim.SetBool ("DoorOpen", true);
			//add sound here 
			SoundManager.instance.PlaySingle(leverDoorOpen);
		}
	}
}
