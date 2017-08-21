using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotator : MonoBehaviour {

	public float rotatespeed = 100f;

	// Update is called once per frame
	void Update () {
		transform.Rotate (0f, 0f, rotatespeed * Time.deltaTime);
	}
}
