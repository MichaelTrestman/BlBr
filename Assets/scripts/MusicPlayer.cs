using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour {
	
	static int instance = 0;

	void Awake() {
		if (instance == 1) {
			Destroy (gameObject);
		} else {
			instance = 1;
			GameObject.DontDestroyOnLoad(gameObject);
		}
	}
}
