using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NewLevel_Logic : MonoBehaviour {
	public string level;
	// Use this for initialization
	void Start () {

	}
		

	void OnTriggerEnter(Collider other)
	{	
		Debug.Log (other.gameObject.tag);
		if (other.gameObject.tag == "Player") {
			SceneManager.LoadScene(level, LoadSceneMode.Single);
		}
		}
	}
	
