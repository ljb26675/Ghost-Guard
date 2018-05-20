using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockController : MonoBehaviour {
	public PlayerController thePlayer;

	public BreakableWallScript wall;

	public bool hasWall;
	// Use this for initialization
	void Start () {
		thePlayer = FindObjectOfType<PlayerController> ();
		wall = FindObjectOfType<BreakableWallScript> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (hasWall == false) {
				if (thePlayer.isSpritePlayer) {
				Physics2D.IgnoreCollision (thePlayer.GetComponent<BoxCollider2D> (), GetComponent<BoxCollider2D> (), true);
			} else {
				Physics2D.IgnoreCollision (thePlayer.GetComponent<BoxCollider2D> (), GetComponent<BoxCollider2D> (), false);
			}
		}

		if (wall.wallBroken) {

			Physics2D.IgnoreCollision (thePlayer.GetComponent<BoxCollider2D> (), GetComponent<BoxCollider2D> (), true);
		} else {

			if (thePlayer.isSpritePlayer) {
				Physics2D.IgnoreCollision (thePlayer.GetComponent<BoxCollider2D> (), GetComponent<BoxCollider2D> (), true);
			} else {
				Physics2D.IgnoreCollision (thePlayer.GetComponent<BoxCollider2D> (), GetComponent<BoxCollider2D> (), false);
			}
		}
	}
}
