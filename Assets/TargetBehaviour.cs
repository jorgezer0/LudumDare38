using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TargetBehaviour : MonoBehaviour {

	Text timer;

	// Use this for initialization
	void Start () {
		timer = GameObject.Find ("Time").GetComponent<Text>();
	}
	
	void OnCollisionEnter(Collision col){
		timer.GetComponent<GameTime> ().go = false;
	}
}
