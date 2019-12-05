using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lift_logic : MonoBehaviour {
	public Element_Logic logic;
	public float speed;
	public float top;
	public float bottom;
	public float dTime;
	// Use this for initialization
	void Start () {
		StartCoroutine (Move());
	}
	
	// Update is called once per frame
	IEnumerator Move ()
	{
		while (true) {
			if (logic.value) {
				if (top > transform.localPosition.y) {
					transform.Translate (Vector3.up * speed);
				}
			} else {
				if (transform.position.y > bottom) {
					transform.Translate (Vector3.up * -speed);
				}
			}
			yield return new WaitForSeconds (dTime);
		}
	}
}
