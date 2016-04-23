using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RatSpawnerPrototype : MonoBehaviour {

	public GameObject ratPrefab;
	private GameObject rat;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	

		if (!GameObject.Find ("phaseController").GetComponent<PhasePrototype> ().buildPhase) {

			//Spawn Up
			if (Input.GetKeyDown (KeyCode.UpArrow)) {

				Instantiate (ratPrefab, new Vector3 (0, 8, 0), Quaternion.identity);
				//gameObject.tag = "rightLaneEnemy";

			}

			//Spawn Down
			if (Input.GetKeyDown (KeyCode.DownArrow)) {

				Instantiate (ratPrefab, new Vector3 (0, -8, 0), Quaternion.identity);


			}

			//Spawn Right
			if (Input.GetKeyDown (KeyCode.RightArrow)) {

				Instantiate (ratPrefab, new Vector3 (8, 0, 0), Quaternion.identity);


			}

			//Spawn Left
			if (Input.GetKeyDown (KeyCode.LeftArrow)) {

				Instantiate (ratPrefab, new Vector3 (-8, 0, 0), Quaternion.identity);


			}


		}
	}
}