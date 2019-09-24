using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Push : MonoBehaviour {
	public Transform t;
	public float force;
	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Mouse0)) {
			gameObject.GetComponent<Rigidbody> ().AddForce (((transform.position - t.position)) / Vector3.Distance (transform.position, t.position) / Vector3.Distance (transform.position, t.position) * force);
			t.gameObject.GetComponent<Rigidbody> ().AddForce ((-(transform.position - t.position)) / Vector3.Distance (transform.position, t.position) / Vector3.Distance (transform.position, t.position) * force);
		}
	}
}
