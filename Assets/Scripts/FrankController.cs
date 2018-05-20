using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrankController : MonoBehaviour {

	public Sprite player;
	public Sprite frank;
	//public bool isSpritePlayer;

	public PlayerController thePlayer;
	//public SpriteRenderer theSpriteRenderer;
	public bool isFrank;

	public LevelManager theLevelManager;

	// Use this for initialization
	void Start () {
		thePlayer = FindObjectOfType<PlayerController> ();
		//theSpriteRenderer = GetComponent<SpriteRenderer> ();
		theLevelManager = FindObjectOfType<LevelManager> ();
		//isFrank = false;
	}

	// Update is called once per frame
	void Update () {
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Player" && thePlayer.isSpritePlayer) {
			//Sprite no longer set to player
			//theLevelManager.Poof();
			//thePlayer.theSpriteRenderer.sprite = frank;
			thePlayer.isSpritePlayer = false;

			theLevelManager.Poof();

			//Sprite set to monster, but all else set to false
			//isFrank = true;
			thePlayer.isSpriteFrank = true;
			thePlayer.isSpriteWere = false;
			thePlayer.isSpriteSkele = false;
			thePlayer.isSpriteSkele = false;

			thePlayer.anim.SetBool("isFrank", true);
			thePlayer.anim.SetBool ("isPlayer", false);
			thePlayer.anim.SetBool ("isSkele", false);
			thePlayer.anim.SetBool ("isWere", false);
			thePlayer.anim.SetBool ("isHuman", false);

			//have monster disappear
			gameObject.SetActive(false);

		}

	}
}
