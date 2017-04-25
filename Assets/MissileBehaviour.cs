using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MissileBehaviour : MonoBehaviour {

	GameObject player;
	Text timer;

	public GameObject gameOverCanvas;

	// Use this for initialization
	void Start () {
		timer = GameObject.Find ("Time").GetComponent<Text>();
		player = GameObject.Find("Turret");
		gameOverCanvas = GameObject.Find ("GameManager").GetComponent<StartGame> ().gameOverCanvas;
	}

	void OnCollisionEnter(Collision col){
		if (col.gameObject.tag == "Target") {
			Debug.Log("HIT!!!");
			player.GetComponent<PlayerControler> ().okToGo = false;
			timer.GetComponent<GameTime> ().go = true;
			gameOverCanvas.SetActive (true);
			//Destroy (col.gameObject);
		}
		Destroy (this.gameObject);
	}
}
