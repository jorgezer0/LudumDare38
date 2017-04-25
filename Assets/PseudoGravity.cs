using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PseudoGravity : MonoBehaviour {

	Rigidbody rigid;
	public float gravity;
	public float pullRadius;
	public float pullForce;

	// Use this for initialization
	void Start () {
		rigid = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		foreach (Collider col in Physics.OverlapSphere(transform.position, pullRadius)){
			if (col.gameObject.tag == "Bomb") {
				Vector3 forceDir = transform.position - col.transform.position;

				col.GetComponent<Rigidbody> ().AddForce (forceDir.normalized * pullForce * Time.fixedDeltaTime);
			}
		}
	}
}
