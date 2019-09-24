using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Push3 : MonoBehaviour {
	public Transform t;
	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		gameObject.GetComponent<Rigidbody>().AddForce(((transform.position - t.position))  / Vector3.Distance(transform.position, t.position) / Vector3.Distance(transform.position, t.position) * 100);
	}
}
