using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class And_Logic : MonoBehaviour {
	public Element_Logic logic1;
	public Element_Logic logic2;
	public Element_Logic logicOut;
	public bool value;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void FixedUpdate () {
		if (logicOut) {
			value = logic1.value & logic2.value;
			logicOut.value = value;
		}
	}
}
