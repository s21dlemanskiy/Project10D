using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
	public GameObject cam;
	public float speed;
	public float sensitivity;
	public float clampAngle;
	float rotX = 0f;
	float rotY = 0f;
	public float jumpForce;
	List<Collider> col = new List<Collider>();
	bool IsGrounded
	{
		get
		{
			return col.Count > 0;
		}
	}
	void FixedUpdate(){
		if (IsGrounded & Input.GetKey("space")) {
			gameObject.GetComponent<Rigidbody>().velocity = (Vector3.up * jumpForce);
			Debug.Log (gameObject.GetComponent<Rigidbody> ().velocity.y);
		}
		transform.Translate (new Vector3(Input.GetAxis("Horizontal"), 0f,Input.GetAxis("Vertical")) * Time.deltaTime * speed);
		rotY += Input.GetAxis("Mouse X") * Time.deltaTime * sensitivity;
		rotX -= Input.GetAxis("Mouse Y") * Time.deltaTime * sensitivity;
		rotX = Mathf.Clamp(rotX, -clampAngle, clampAngle);
		cam.transform.localRotation = Quaternion.Euler(rotX, 0f , 0.0f);
		transform.rotation = Quaternion.Euler(0f, rotY , 0.0f);
	}
	void OnCollisionStay(Collision coll)
	{

		// Debug.Log (col);   
		if (!col.Contains (coll.collider)) {  
			foreach (var p in coll.contacts) {
				//Debug.Log (p.point.y + "|" + GetComponent<Collider2D> ().bounds.min.y);
				if (Mathf.Abs(p.point.y - GetComponent<Collider> ().bounds.min.y) < 0.05) {
					col.Add (coll.collider);
					break;
					//Debug.Log ("added" + p.collider.gameObject.name);
				}
			}
		}
	}
	void OnCollisionExit(Collision coll)
	{
		//Debug.Log (coll.collider.gameObject.name);
		col.Remove(coll.collider);
		//Debug.Log ("ex" + col);
	}
	// Use this for initialization
	void Start () {
		
	}
}
