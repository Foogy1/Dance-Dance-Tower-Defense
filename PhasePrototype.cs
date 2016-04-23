using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PhasePrototype : MonoBehaviour {

	int count = 0;
	public bool buildPhase = true;

	public Color phaseColor = Color.green /*= red;*/;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		count++;

		if (count >= 300) {

			buildPhase = false;
			phaseColor = Color.red;
			this.GetComponent<SpriteRenderer> ().color = phaseColor;

		}




	}
}
