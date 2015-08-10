using UnityEngine;
using System.Collections;

public class Camera : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp(KeyCode.A)){
			gameObject.camera.orthographicSize++;
		} else if (Input.GetKeyUp(KeyCode.Z)){
			gameObject.camera.orthographicSize--;
		}
		
		if (Input.GetKeyUp(KeyCode.Q)){
			Time.timeScale = Time.timeScale * .8f;
		} else if (Input.GetKeyUp(KeyCode.W)){
			Time.timeScale = Time.timeScale * 1.2f;
		}
	}
}
