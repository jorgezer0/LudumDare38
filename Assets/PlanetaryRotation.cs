using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetaryRotation : MonoBehaviour {

	public Transform sun;
	public Color color;
	public int speed;
	float orbitalSpeed;

	// Use this for initialization
	void Start () {
		sun = GameObject.Find ("Star").transform;
		//color = Color (Random.Range (0, 1), Random.Range (0, 1), Random.Range (0, 1), 1);
		color = Random.ColorHSV ();
		GetComponent<MeshRenderer> ().material.color = color;
	}
	
	// Update is called once per frame
	void Update () {
		float dist = Vector3.Distance (sun.position, transform.position);
		orbitalSpeed = (speed / dist) * Time.deltaTime;
		transform.Rotate (Vector3.forward * orbitalSpeed * 2);
		transform.RotateAround (sun.transform.position, Vector3.forward, orbitalSpeed);


	}
}
