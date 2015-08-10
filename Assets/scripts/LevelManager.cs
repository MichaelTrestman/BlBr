using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public void LoadLevel (string name ) {
		//Brick.breakableCount = 0;
		Brick.ClearBricks();
		Application.LoadLevel(name);
	}
	
	public static void LoadNextLevel () {
		//Brick.breakableCount = 0;
		Brick.ClearBricks();
		Application.LoadLevel(Application.loadedLevel + 1);
	}
	
	public void QuitReqeust () {
		Application.Quit();
	}
	
	public static void BrickDestroyed (){
		if (Brick.breakableCount <= 0) {
			LoadNextLevel();
		}
	}
}
