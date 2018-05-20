using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float moveSpeed;

	public Rigidbody2D myRigidbody;
	public Animator anim;

	public float jumpSpeed;

	public Transform groundCheck;
	public float groundCheckRadius;
	public LayerMask whatIsGround;

	public bool isGrounded;
	public SpriteRenderer theSpriteRenderer;

	public Sprite player;
	public Sprite werewolf;
	public Sprite skeleton;
	public Sprite frankenstein;

	public bool isSpritePlayer;
	public bool isSpriteSkele;
	public bool isSpriteWere;
	public bool isSpriteFrank;
	public bool isSpriteHuman;

	public SkeletonController theSkeleton;
	public WerewolfController theWerewolf;
	public FrankController theFrank;
	public HumanController theHuman;

	public LevelManager theLevelManager;

	public AudioClip possessSound;






	// Use this for initialization
	void Start () {
		myRigidbody = GetComponent<Rigidbody2D> ();
		theSpriteRenderer = GetComponent<SpriteRenderer> ();
		anim = GetComponent<Animator> ();
		theLevelManager = FindObjectOfType<LevelManager> ();
		anim.SetBool ("isPlayer", true);
		anim.SetBool ("WalkRight", true);

		theSkeleton = FindObjectOfType<SkeletonController> ();
		theWerewolf = FindObjectOfType<WerewolfController> ();
		theFrank = FindObjectOfType<FrankController> ();
		theHuman = FindObjectOfType<HumanController> ();

		isSpritePlayer = true;

	}
	
	// Update is called once per frame
	void Update () {
		isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);


		//control player movement
		if (Input.GetAxisRaw ("Horizontal") > 0f) {
			anim.SetBool ("WalkRight", false);
			myRigidbody.velocity = new Vector3 (moveSpeed, myRigidbody.velocity.y, 0f);
			//anim.SetFloat ("Speed", Mathf.Abs (myRigidbody.velocity.x));
			//sound moving right here
			GetComponent<AudioSource>().UnPause();
				transform.localScale = new Vector3 (1f, 1f, 1f);
		} else if (Input.GetAxisRaw ("Horizontal") < 0f) {
			anim.SetBool ("WalkRight", true);
			myRigidbody.velocity = new Vector3 (-moveSpeed, myRigidbody.velocity.y, 0f);
			transform.localScale = new Vector3 (-1f, 1f, 1f);
			//anim.SetFloat ("Speed", Mathf.Abs (myRigidbody.velocity.x));
				transform.localScale = new Vector3 (-1f, 1f, 1f);
			//sound moving right here
			GetComponent<AudioSource>().UnPause();
		} else {
			myRigidbody.velocity = new Vector3 (0f, myRigidbody.velocity.y, 0f); 
			//anim.SetFloat ("Speed", Mathf.Abs (myRigidbody.velocity.x));
			GetComponent<AudioSource>().Pause();
		}

		if (Input.GetButtonDown ("Jump") && isGrounded){
			//if (isSpritePlayer == false) {
				myRigidbody.velocity = new Vector3(myRigidbody.velocity.x, jumpSpeed, 0f); //player can't jump if a ghost
				//stop moving sound
			//}
		}

		anim.SetFloat ("Speed", Mathf.Abs (myRigidbody.velocity.x));

		//if player presses p, and is a monster
		if (Input.GetKey ("p") && isSpritePlayer == false) {
			//Sprite previous = theSpriteRenderer.sprite;
			//theSpriteRenderer.sprite = player;

			theLevelManager.Poof();
			//thePlayer.theSpriteRenderer.sprite = frank;
			anim.SetBool("isFrank", false);
			anim.SetBool ("isPlayer", true);
			anim.SetBool ("isSkele", false);
			anim.SetBool ("isWere", false);
			anim.SetBool ("isHuman", false);

			isSpritePlayer = true;
			isSpriteFrank = false;
			isSpriteWere = false;
			isSpriteSkele = false;
			//isSpriteHuman = false;


			theSkeleton.gameObject.SetActive(true);
			theSkeleton.anim.SetBool ("Rose", true);
			theWerewolf.gameObject.SetActive(true);
			theFrank.gameObject.SetActive(true);
			theHuman.gameObject.SetActive(true);

			//sound
			SoundManager.instance.PlaySingle(possessSound);

		}
	}
		
}
