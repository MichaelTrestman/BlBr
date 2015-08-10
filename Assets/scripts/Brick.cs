using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {
	
	public static int breakableCount = 0;
	public AudioClip crack;
	
	private int timesHit;
	private LevelManager levelMan;
	public Sprite[] hitSprites;
	
	private bool isBreakable;
	
	// Use this for initialization
	void Start () {
		timesHit = 0;
		
		levelMan = FindObjectOfType<LevelManager>();
	
		isBreakable = (this.tag == "Breakable");
		
		if (isBreakable) {
			breakableCount++;
		}
		
		print (breakableCount);
	}
	
	void OnCollisionEnter2D (Collision2D collision){
		AudioSource.PlayClipAtPoint (crack, transform.position);
		if (isBreakable) { 
			HandleHits();
		}
	}
	
	void HandleHits (){
		timesHit ++;
		int maxHits = hitSprites.Length + 1;
		if (timesHit >= maxHits){
			breakableCount--;
			print (breakableCount);
			LevelManager.BrickDestroyed();
			Destroy(gameObject);
		} else {
			LoadSprites ();
		}
	}
	// Update is called once per frame
	void Update () {
	}
	
	void LoadSprites (){
		int spriteIndex = timesHit -1;
		if (hitSprites[spriteIndex]){
			this.GetComponent<SpriteRenderer>().sprite = hitSprites[spriteIndex];
		}
	}
	public static void ClearBricks(){
		breakableCount = 0;
	}
}
