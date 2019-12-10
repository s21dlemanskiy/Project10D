using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiftTrigger_Logic : MonoBehaviour {
	public Element_Logic logic;
	List<Collider> cols = new List<Collider>();
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void FixedUpdate () {
		logic.value = cols.Count > 0;
	}

	void OnTriggerEnter(Collider other)
	{	
		Debug.Log (other.gameObject.tag);
		if (other.gameObject.tag == "Lift") {
			cols.Add (other);
		}
	}
	void OnTriggerExit(Collider other)
	{
		if (other.gameObject.tag == "Lift") {
			cols.Remove (other);
		}
	}
}
