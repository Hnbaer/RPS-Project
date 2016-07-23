using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ButtonControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
		SceneManager.SetActiveScene(SceneManager.GetSceneByName("MainMenuScene"));
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void _goToScene(string givenSceneName)
	{
		AudioSource audioSource = Engine.self.GetComponent<AudioSource>();
		audioSource.clip = Engine.self.song1;
		audioSource.Play();
		SceneManager.LoadScene(givenSceneName, LoadSceneMode.Additive);
		SceneManager.UnloadScene("MainMenuScene");
	}
}
