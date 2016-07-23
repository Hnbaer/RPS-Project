using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public enum GameState {InitGame, MainMenu, MatchMaking, Options, Playing}
public enum PlayState {InitPlay, Play, Win, Lose, Quit }
public class Engine : MonoBehaviour {

	public static Engine self;

	public AudioClip song1;

	GameState currentGameState;
	string mainSceneName = "MainMenuScene";

	// Use this for initialization
	void Start () {
		self = this;
		currentGameState = GameState.InitGame;
	}
	
	// Update is called once per frame
	void Update () {
		switch(currentGameState)
		{
			case GameState.InitGame:
				SceneManager.LoadScene(mainSceneName, LoadSceneMode.Additive);
				//To Do : Query Database
				currentGameState = GameState.MainMenu;
				break;
			case GameState.MainMenu:
				break;
			case GameState.MatchMaking:
				//To Do : Query For Players currently playing the game
				break;
			case GameState.Options:
				break;
			case GameState.Playing:
				break;
		}
	
	}
}
