using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanController : MonoBehaviour {
	
	public Sprite player;
	public Sprite human;
	//public bool isSpritePlayer;
	//public GameObject objectToMove;

	//public Rigidbody2D myRigidbody;

	public Transform start;
	public Transform end;

	public float moveSpeed;

	private Vector3 currentTarget;
	public PlayerController thePlayer;

	public SpriteRenderer theSpriteRenderer;
	public LevelManager theLevelManager;

	// Use this for initialization
	void Start () {
		thePlayer = FindObjectOfType<PlayerController> ();
		//myRigidbody = GetComponent<Rigidbody2D> ();
		theSpriteRenderer = GetComponent<SpriteRenderer> ();
		theLevelManager = FindObjectOfType<LevelManager> ();

	}

	// Update is called once per frame
	void Update () {
		//move human to the door. If can't reach door (encounters a collider), reset level

		//FIND HUMANS'S POSITION
		//transform.position = Vector3.MoveTowards(transform.position, end.position, moveSpeed * Time.deltaTime);


	}

	//ontriggerenter would be better for button pressing to do something
	void OnTriggerEnter2D(Collider2D other){

		if (other.tag == "Player" && thePlayer.isSpritePlayer) {

			//Sprite no longer set to player
			//thePlayer.theSpriteRenderer.sprite = human;
			thePlayer.isSpritePlayer = false;
			thePlayer.anim.SetBool("isFrank", false);
			thePlayer.anim.SetBool ("isPlayer", false);
			thePlayer.anim.SetBool ("isSkele", false);
			thePlayer.anim.SetBool ("isWere", false);
			thePlayer.anim.SetBool ("isHuman", true);

			theLevelManager.Poof();

			//Sprite set to monster, but all else set to false
			//isSkeleton = true;
			thePlayer.isSpriteSkele = false;
			thePlayer.isSpriteWere = false;
			thePlayer.isSpriteFrank = false;
			thePlayer.isSpriteHuman = true;


			//have monster disappear
			gameObject.SetActive(false);
		}
	}



}
