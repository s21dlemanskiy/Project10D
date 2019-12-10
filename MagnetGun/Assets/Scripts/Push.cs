using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Push : MonoBehaviour {
	public Transform t;
	public float force;
	private float len;
	GameObject[] pieces;
	GameObject minObj;
	float minD;
	// Use this for initialization
	void Start () {

		pieces = MetalPiecesList.instance.metalPieces;
		minObj = pieces [0];
	}

	// Update is called once per frame
	void FixedUpdate () {
		minD = Mathf.Abs((Camera.main.WorldToScreenPoint (minObj.transform.position) - new Vector3(Camera.main.pixelWidth / 2, Camera.main.pixelHeight / 2)).magnitude);
		//Debug.Log (minD);
		foreach (GameObject piece in pieces) {
			len = Mathf.Abs((Camera.main.WorldToScreenPoint (piece.transform.position) - new Vector3(Camera.main.pixelWidth / 2, Camera.main.pixelHeight / 2)).magnitude);
			if(len < minD){
				minD = len;
				minObj = piece;
			}

		}
		t = minObj.transform;
		if (Input.GetKey (KeyCode.Mouse0) & minD < 150) {
			gameObject.GetComponent<Rigidbody> ().AddForce (((transform.position - t.position)) / Vector3.Distance (transform.position, t.position) / Vector3.Distance (transform.position, t.position) * force);
			t.gameObject.GetComponent<Rigidbody> ().AddForce ((-(transform.position - t.position)) / Vector3.Distance (transform.position, t.position) / Vector3.Distance (transform.position, t.position) * force);
		}
	}
}
