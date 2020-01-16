using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lift_logic : MonoBehaviour {
	public Element_Logic logic;
	public Element_Logic logicOut;
	public float speed;
	public float top;
	public float bottom;
	public float doorsOpenHeight;
	public float dTime;
	public Transform player;
	public Element_Logic playerIn;
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
					transform.Translate (Vector3.up * speed * Time.deltaTime);
				}
			} else {
				if ((transform.position.y > bottom) || playerIn.value) {
					transform.Translate (Vector3.up * -speed * Time.deltaTime);
					if (playerIn.value) {
						player.Translate (Vector3.up * -speed * Time.deltaTime);
					}
				}
			}
			Debug.Log (transform.localPosition.y);
			logicOut.value = doorsOpenHeight < transform.localPosition.y;
			yield return new WaitForSeconds (dTime);
		}
	}
}
