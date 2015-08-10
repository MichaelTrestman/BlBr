using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
	
	private Paddle paddle;
	private Vector3 paddleToBallVector;
	private bool gameStarted;
	
	// Use this for initialization
	void Start () {
		paddle = FindObjectOfType<Paddle>();
		paddleToBallVector = this.transform.position - paddle.transform.position;
		gameStarted = false;
	}
	
	// Update is called once per frame
	void Update () {
		
		if (!gameStarted){
		
			this.transform.position = paddle.transform.position + paddleToBallVector;
			
			if (Input.GetMouseButtonDown(0)){
				gameStarted = true;
				this.rigidbody2D.velocity = new Vector2 (0f, -15f);
			}
		}
	}
	
	void OnCollisionEnter2D(Collision2D col2){
		Vector2 tweak = new Vector2 (Random.Range(0f, 0.2f), Random.Range(0f, 0.2f));
		
		if (gameStarted) {
			audio.Play();
			rigidbody2D.velocity += tweak;
		}
		
	}
}
