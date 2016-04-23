using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RatPathingPrototype : MonoBehaviour {

	float step = 0.01f;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		transform.position = Vector3.MoveTowards (transform.position, new Vector3 (0, 0, 0), step);

	}
}