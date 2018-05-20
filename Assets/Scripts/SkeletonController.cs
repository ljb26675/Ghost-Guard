using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonController : MonoBehaviour {

	public Sprite player;
	public Sprite skeleton;
	public Animator anim;
	//public bool isSpritePlayer;

	public PlayerController thePlayer;
	public LevelManager theLevelManager;

	public bool isSkeleton;
	//public SpriteRenderer theSpriteRenderer;

	// Use this for initialization
	void Start () {
		thePlayer = FindObjectOfType<PlayerController> ();
		anim = GetComponent<Animator> ();
		theLevelManager = FindObjectOfType<LevelManager> ();
		//theSpriteRenderer = GetComponent<SpriteRenderer> ();
		isSkeleton = false;
		anim.SetBool("Rose", true);

	}

	// Update is called once per frame
	void Update () {
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Player" && thePlayer.isSpritePlayer) {

			//Sprite no longer set to player
			//thePlayer.theSpriteRenderer.sprite = skeleton;
			thePlayer.isSpritePlayer = false;
			thePlayer.anim.SetBool("isFrank", false);
			thePlayer.anim.SetBool ("isPlayer", false);
			thePlayer.anim.SetBool ("isSkele", true);
			thePlayer.anim.SetBool ("isWere", false);
			thePlayer.anim.SetBool ("isHuman", false);

			theLevelManager.Poof();

			//Sprite set to monster, but all else set to false
			//isSkeleton = true;
			thePlayer.isSpriteSkele = true;
			thePlayer.isSpriteWere = false;
			thePlayer.isSpriteFrank = false;
			thePlayer.isSpriteHuman = false;


			//have monster disappear
			gameObject.SetActive(false);
		}

	}
}
