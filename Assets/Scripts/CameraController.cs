using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public GameObject target;
	public float followAhead;

	private Vector3 targetPosition;

	public float smoothing;

	public bool followTarget;

	float newHeight = 4.8f;

	public Camera camera;

	public bool introDone;

	public IntroAnimation intro;

	// Use this for initialization
	void Start () {
		//camera = FindObjectOfType<Camera> ();
		//Debug.Log (Screen.width);
		//if((Screen.width / ((float)Screen.height)) < 5f/3f;//{
		//	Debug.Log ("camera changed");
		//newHeight = Screen.height / ((float)Screen.width) * 4;
		//	camera.orthographicSize = newHeight;
		//}
		intro = FindObjectOfType<IntroAnimation>();
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log (camera.pixelWidth);
		//Debug.Log (camera.pixelHeight);

		targetPosition = new Vector3(target.transform.position.x, transform.position.y, transform.position.z);

		if (target.transform.localScale.x > 0f) {
			targetPosition = new Vector3(targetPosition.x, targetPosition.y, targetPosition.z);
		} else {
			targetPosition = new Vector3(targetPosition.x, targetPosition.y, targetPosition.z);
		}

		if (introDone) {
			transform.position = Vector3.Lerp (transform.position, targetPosition, smoothing * Time.deltaTime);
		} else if (intro == null) {
			transform.position = Vector3.Lerp (transform.position, targetPosition, smoothing * Time.deltaTime);
		}
	}
}
