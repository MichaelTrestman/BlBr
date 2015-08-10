using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {
	public bool playerControl;
	// Use this for initialization
	private Ball ball;
	
	void Start () {
		if (!playerControl){
			ball = FindObjectOfType<Ball>();
		}
	}
	
	// Update is called once per frame
	void Update () {
	
		if (playerControl) {
			MoveWithMouse();
		} else {
			MoveWithBall();
		};	
	
    


		Vector3 rotationVector = transform.rotation.eulerAngles;

		if (Input.GetKeyDown(KeyCode.X)){
			rotationVector.z = 10;
		} else if (Input.GetKeyDown(KeyCode.C)){
			rotationVector.z = 0;
		} else if (Input.GetKeyDown(KeyCode.V)){
			rotationVector.z = -10;
		}
		
		transform.rotation = Quaternion.Euler(rotationVector);
		
	}

	void MoveWithMouse (){
		Vector3 paddlePos = new Vector3 (0.5f, this.transform.position.y, 0f);
		float mousePosInBlocks = Input.mousePosition.x / Screen.width * 16;
		mousePosInBlocks = 
			Mathf.Clamp(
				mousePosInBlocks,
				0.5f,
				15.5f
			);
		paddlePos.x = mousePosInBlocks;
		this.transform.position = paddlePos;
	}
	void MoveWithBall (){
		Vector3 paddlePos = new Vector3 (0.5f, this.transform.position.y, 0f);
		paddlePos.x = ball.transform.position.x;
		this.transform.position = paddlePos;
	}


}
