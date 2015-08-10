using UnityEngine;
using System.Collections;

public class LoseCollider : MonoBehaviour {

	private LevelManager levelMan;
	
	void Start (){
		levelMan = FindObjectOfType<LevelManager>();
	}
	void OnTriggerEnter2D (Collider2D trigger){
		levelMan.LoadLevel("Lose");
	}
	
	void OnCollisionEnter2D (Collision2D collision){
	}
}
