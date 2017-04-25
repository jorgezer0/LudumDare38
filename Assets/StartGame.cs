using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartGame : MonoBehaviour {

	GameObject player;
	public GameObject timer;

	public GameObject titleCanvas;
	public GameObject uiCanvas;
	public GameObject gameOverCanvas;

	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Turret");
		titleCanvas = GameObject.Find ("Title_Canvas");
		uiCanvas = GameObject.Find ("UI_Canvas");
		gameOverCanvas = GameObject.Find ("GameOver_Canvas");
		uiCanvas.SetActive(false);
		gameOverCanvas.SetActive (false);
	}
	
	public void BeginGame(){
		player.GetComponent<PlayerControler>().okToGo = true;
		timer.GetComponent<GameTime> ().go = false;
		titleCanvas.SetActive(false);
		uiCanvas.SetActive(true);
	}

	public void TryAgain(){
		timer.GetComponent<GameTime> ().Reset ();
		player.GetComponent<PlayerControler> ().shootCount = 0;
		player.GetComponent<PlayerControler>().okToGo = true;
		timer.GetComponent<GameTime> ().go = false;
		titleCanvas.SetActive(false);
		uiCanvas.SetActive(true);
		gameOverCanvas.SetActive (false);
	}
}
