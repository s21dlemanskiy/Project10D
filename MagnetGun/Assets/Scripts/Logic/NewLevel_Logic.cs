using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NewLevel_Logic : MonoBehaviour {
	// Use this for initialization
	void Start () {

	}
		

	void OnTriggerEnter(Collider other)
	{	
		Debug.Log (other.gameObject.tag);
		if (other.gameObject.tag == "Player") {
			SceneManager.LoadScene("test2", LoadSceneMode.Single);
		}
		}
	}
	
