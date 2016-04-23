using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class NormalEnemyStats : MonoBehaviour {


	public int startingHealthNormalEnemy = 100;
	public int currentHealthNormalEnemy;

	public bool inRightLane = false;
	public bool inLeftLane = false;
	public bool inDownLane = false;
	public bool inUpLane = false;

	//GameObject rightLane = GameObject.Find ("rightLane");



	void Start () {
	

		currentHealthNormalEnemy = startingHealthNormalEnemy;





	}



	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.name == "rightLane") {

			gameObject.tag = "rightLaneEnemy";
			inRightLane = true;
			Debug.Log ("I spawned in the right lane");

		}



	}

	

	void Update () {
	
	}
}
