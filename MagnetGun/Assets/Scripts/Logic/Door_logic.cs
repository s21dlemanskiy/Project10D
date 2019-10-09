using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_logic : MonoBehaviour {
	public Element_Logic logic;
	public Animator anim;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		anim.SetBool("isOpen", logic.value);
	}
}
