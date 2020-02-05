using System.Collections;

using System.Collections.Generic;

using UnityEngine;

public class deadplane : MonoBehaviour
{
	public float x, y, z;
	void OnTriggerEnter(Collider other)
	{
		other.transform.position = new Vector3(x, y, z);
	}
}