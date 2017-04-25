using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControler : MonoBehaviour {

	public GameObject head;
	public GameObject muzzle;
	public float speed;
	public GameObject missile;
	public float missileSpeed;

	public int shootCount = 0;
	public Text showCount;

	public bool okToGo = true;

	// Use this for initialization
	void Start () {
		head = GameObject.Find("Head");
	}
	
	// Update is called once per frame
	void Update () {
		
			var pos = Camera.main.WorldToScreenPoint (transform.position);
			var dir = Input.mousePosition - pos;
			var angle = Mathf.Atan2 (dir.y, dir.x) * Mathf.Rad2Deg;
			head.transform.rotation = Quaternion.AngleAxis (angle, Vector3.forward); 

		if ((Input.GetMouseButtonDown (0)) && (okToGo)) {
				GameObject tempMissile = Instantiate (missile, muzzle.transform.position, Quaternion.identity);
				tempMissile.transform.Rotate (head.transform.rotation.eulerAngles);
				tempMissile.GetComponent<Rigidbody> ().AddForce ((head.transform.rotation * Vector3.right) * missileSpeed);
				shootCount++;
				showCount.text = ("SHOOTS: " + shootCount.ToString ());
			}
		
	}
}
