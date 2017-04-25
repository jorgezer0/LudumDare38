using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTime : MonoBehaviour {

	float tempmili = 0;
	int mili = 0;
	int sec = 0;
	int min = 0;

	public Text timer;
	public bool go;

	void Awake(){
		timer = GetComponent<Text> ();
	}

	// Update is called once per frame
	void Update () {
		if (!go) {
			tempmili += Time.deltaTime * 1000;
			mili = Mathf.FloorToInt (tempmili);
			if (mili > 950) {
				tempmili = 0;
				sec++;
				if (sec > 59) {
					min++;
					sec = 0;
				}

			}
			if (sec < 10) {
				if (mili < 9) {
					timer.text = string.Format ("{0}:0{1}:00{2}", min, sec, mili);
				} else if (mili < 99) {
					timer.text = string.Format ("{0}:0{1}:0{2}", min, sec, mili);
				} else if (mili > 100) {
					timer.text = string.Format ("{0}:0{1}:{2}", min, sec, mili);
				}
			} else if (sec > 9) {
				if (mili < 9) {
					timer.text = string.Format ("{0}:{1}:00{2}", min, sec, mili);
				} else if (mili < 99) {
					timer.text = string.Format ("{0}:{1}:0{2}", min, sec, mili);
				} else if (mili > 100) {
					timer.text = string.Format ("{0}:{1}:{2}", min, sec, mili);
				}
			}
		}
	}

	public void Reset(){
		tempmili = 0;
		mili = 0;
		sec = 0;
		min = 0;
	}
}
