using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WerewolfController : MonoBehaviour {

	public Sprite player;
	public Sprite werewolf;
	//public bool isSpritePlayer;

	public PlayerController thePlayer;
	//public SpriteRenderer theSpriteRenderer;
	public bool isWere;
	public LevelManager theLevelManager;

	// Use this for initialization
	void Start () {
		thePlayer = FindObjectOfType<PlayerController> ();
		theLevelManager = FindObjectOfType<LevelManager> ();
		//theSpriteRenderer = GetComponent<SpriteRenderer> ();
		isWere = false;

	}

	// Update is called once per frame
	void Update () {
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Player" && thePlayer.isSpritePlayer) {

			//Sprite no longer set to player
			//thePlayer.theSpriteRenderer.sprite = werewolf;
			thePlayer.isSpritePlayer = false;

			theLevelManager.Poof();
			thePlayer.anim.SetBool("isFrank", false);
			thePlayer.anim.SetBool ("isPlayer", false);
			thePlayer.anim.SetBool ("isSkele", false);
			thePlayer.anim.SetBool ("isWere", true);
			thePlayer.anim.SetBool ("isHuman", false);

			//Sprite set to monster, but all else set to false
			//isWere = true;

			thePlayer.isSpriteWere = true;
			thePlayer.isSpriteSkele = false;
			thePlayer.isSpriteFrank = false;
			thePlayer.isSpriteHuman = false;
			//Debug.Log (thePlayer.isSpriteWere);

			//have monster disappear
			gameObject.SetActive(false);
		}

	}
}
