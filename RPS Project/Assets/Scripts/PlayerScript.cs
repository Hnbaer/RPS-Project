using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

	public Sprite [] spriteARR;

	// Use this for initialization
	void Start () {
	}

	public void setSprite(int num){
		GetComponent<SpriteRenderer>().sprite = spriteARR[num];

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
