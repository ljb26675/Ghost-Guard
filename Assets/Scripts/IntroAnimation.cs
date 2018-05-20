using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroAnimation : MonoBehaviour {
	public Animator anim;
	public Animation animation;

	public CameraController camera;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		anim.SetBool ("PlayedOnce", false);
		camera = FindObjectOfType<CameraController> ();
	}
	
	// Update is called once per frame
	void Update () {
		anim.SetBool ("PlayedOnce", true);

		if (anim.GetCurrentAnimatorStateInfo(0).IsName("IntroAnimation") == false){
			camera.introDone = true;
			Destroy (gameObject);
		}
	}
}
