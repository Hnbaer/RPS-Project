using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Choice : MonoBehaviour {
	
	public string type = "none";
	Button button;
	public int spr = 0;
	public PlayerScript player;

	// Use this for initialization
	void Start () {

		button = GetComponent<Button> ();

		button.onClick.AddListener (
			delegate {
				player.subCard(spr);
				player.setSprite(spr);
			}
		);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
