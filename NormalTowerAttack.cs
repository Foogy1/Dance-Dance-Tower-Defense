using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class NormalTowerAttack : MonoBehaviour {

private bool rightTower = false;
private bool leftTower = false;
private bool upTower = false;
private bool downTower = false;



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	




	}


	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.name == "rightLane") {

			rightTower = true;
			Debug.Log ("I am a right tower");
		}

	

}

	GameObject FindNextEnemy() {
		GameObject[] enemies;



		if (rightTower=true){
			enemies = GameObject.FindGameObjectsWithTag ("rightLaneEnemy");
			GameObject target;
			float distance = Mathf.Infinity;
			Vector2 position = transform.position;
			//foreach (GameObject go in enemies

			return target;
				}


	}




}