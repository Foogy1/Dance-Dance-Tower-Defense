using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TowerSpawnerPrototype : MonoBehaviour {

	public GameObject towerPrefab;
	private GameObject tower;

	//public Vector3 (1, 1, 0); //towerR0
	//public Vector3 (1, -1, 0); //towerR1
	//public Vector3 (1, 1, 0); //towerR0


	int rightCount = 1;
	int leftCount = 1;
	int upCount = 1;
	int downCount = 1;


	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {



		if (GameObject.Find ("phaseController").GetComponent<PhasePrototype> ().buildPhase) {

			//Right Towers
			if (Input.GetKeyDown (KeyCode.RightArrow)) {

				//tower = (GameObject);

				if (rightCount == 1) {
					Instantiate (towerPrefab, new Vector3 (2, 1, 0), Quaternion.identity);
				}

				if (rightCount == 2) {
					Instantiate (towerPrefab, new Vector3 (2, -1, 0), Quaternion.identity);
				}

				if (rightCount == 3) {
					Instantiate (towerPrefab, new Vector3 (4, 1, 0), Quaternion.identity);
				}

				if (rightCount == 4) {
					Instantiate (towerPrefab, new Vector3 (4, -1, 0), Quaternion.identity);
				}

				if (rightCount == 5) {
					Instantiate (towerPrefab, new Vector3 (6, 1, 0), Quaternion.identity);
				}

				if (rightCount == 6) {
					Instantiate (towerPrefab, new Vector3 (6, -1, 0), Quaternion.identity);
				}

				rightCount++;

			}


			//Left Towers
			if (Input.GetKeyDown (KeyCode.LeftArrow)) {

			

				if (leftCount == 1) {
					Instantiate (towerPrefab, new Vector3 (-2, 1, 0), Quaternion.identity);
				}

				if (leftCount == 2) {
					Instantiate (towerPrefab, new Vector3 (-2, -1, 0), Quaternion.identity);
				}

				if (leftCount == 3) {
					Instantiate (towerPrefab, new Vector3 (-4, 1, 0), Quaternion.identity);
				}

				if (leftCount == 4) {
					Instantiate (towerPrefab, new Vector3 (-4, -1, 0), Quaternion.identity);
				}

				if (leftCount == 5) {
					Instantiate (towerPrefab, new Vector3 (-6, 1, 0), Quaternion.identity);
				}

				if (leftCount == 6) {
					Instantiate (towerPrefab, new Vector3 (-6, -1, 0), Quaternion.identity);
				}

				leftCount++;

			}


			//Up Towers
			if (Input.GetKeyDown (KeyCode.UpArrow)) {



				if (upCount == 1) {
					Instantiate (towerPrefab, new Vector3 (1, 2, 0), Quaternion.identity);
				}

				if (upCount == 2) {
					Instantiate (towerPrefab, new Vector3 (-1, 2, 0), Quaternion.identity);
				}

				if (upCount == 3) {
					Instantiate (towerPrefab, new Vector3 (1, 4, 0), Quaternion.identity);
				}

				if (upCount == 4) {
					Instantiate (towerPrefab, new Vector3 (-1, 4, 0), Quaternion.identity);
				}

				if (upCount == 5) {
					Instantiate (towerPrefab, new Vector3 (1, 6, 0), Quaternion.identity);
				}

				if (upCount == 6) {
					Instantiate (towerPrefab, new Vector3 (-1, 6, 0), Quaternion.identity);
				}

				upCount++;

			}


			//Down Towers
			if (Input.GetKeyDown (KeyCode.DownArrow)) {



				if (downCount == 1) {
					Instantiate (towerPrefab, new Vector3 (1, -2, 0), Quaternion.identity);
				}

				if (downCount == 2) {
					Instantiate (towerPrefab, new Vector3 (-1, -2, 0), Quaternion.identity);
				}

				if (downCount == 3) {
					Instantiate (towerPrefab, new Vector3 (1, -4, 0), Quaternion.identity);
				}

				if (downCount == 4) {
					Instantiate (towerPrefab, new Vector3 (-1, -4, 0), Quaternion.identity);
				}

				if (downCount == 5) {
					Instantiate (towerPrefab, new Vector3 (1, -6, 0), Quaternion.identity);
				}

				if (downCount == 6) {
					Instantiate (towerPrefab, new Vector3 (-1, -6, 0), Quaternion.identity);
				}

				downCount++;

			}

		}


	}

	//void OnRightArrowDown (){
	//	tower = (GameObject);
	//	Instantiate(towerPrefab





}