using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Element_Logic : MonoBehaviour {
	public Element_Logic logic;
	public bool value;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (logic) {
			logic.value = value;
		}
	}
}
