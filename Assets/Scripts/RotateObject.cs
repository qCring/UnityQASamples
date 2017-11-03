using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour {

	private Vector3 speed = new Vector3 (0f, 0f, 0.25f);

	void Update () {
		this.transform.Rotate (speed);
	}
}
