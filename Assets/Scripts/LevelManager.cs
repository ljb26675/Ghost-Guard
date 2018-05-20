using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {
	public float waitToRespawn;
	public PlayerController thePlayer;

	public GameObject playerChange;

	// Use this for initialization
	void Start () {
		thePlayer = FindObjectOfType<PlayerController> ();

	}
	
	// Update is called once per frame
	void Update () {
		
	}
		
	public void Poof(){

		Instantiate (playerChange, thePlayer.transform.position, thePlayer.transform.rotation);

	}
}
