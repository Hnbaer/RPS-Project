using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {
	public int suitAmt = 3;
	public int perSuit = 3;
	public Sprite [] spriteARR;
	public int [] cards;

	// Use this for initialization
	void Start () {
		int i;
		cards = new int[suitAmt];
		for (i = 0; i < 3; i++) {
			cards [i] = perSuit;
		}


	}

	public void setSprite(int num){
		GetComponent<SpriteRenderer>().sprite = spriteARR[num];

	}

	public void subCard(int _type){
		cards [(_type - 1)] -= 1;
	}
	// Update is called once per frame
	void Update () {
		
	}
}
