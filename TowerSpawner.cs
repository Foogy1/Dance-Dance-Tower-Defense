using UnityEngine;
using System.Collections;

public class TowerSpawner : MonoBehaviour {

	public GameObject towerPrefab;
	private GameObject tower;

	//public Vector3 (1, 1, 0); //towerR0
	//public Vector3 (1, -1, 0); //towerR1
	//public Vector3 (1, 1, 0); //towerR0


	int rightCount = 1;
	int upCount = 1;


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	

		//Right Towers
		if(Input.GetKeyDown(KeyCode.RightArrow)){

			//tower = (GameObject);

			if(rightCount==1){
				Instantiate(towerPrefab, new Vector3(2, 1, 0), Quaternion.identity);
			}

			if(rightCount==2){
				Instantiate(towerPrefab, new Vector3(2, -1, 0), Quaternion.identity);
			}

			if(rightCount==3){
				Instantiate(towerPrefab, new Vector3(4, 1, 0), Quaternion.identity);
			}

			if(rightCount==4){
				Instantiate(towerPrefab, new Vector3(4, -1, 0), Quaternion.identity);
			}

			if(rightCount==5){
				Instantiate(towerPrefab, new Vector3(6, 1, 0), Quaternion.identity);
			}

			if(rightCount==6){
				Instantiate(towerPrefab, new Vector3(6, -1, 0), Quaternion.identity);
			}

			rightCount++;

		}

		//Up Towers
		if(Input.GetKeyDown(KeyCode.UpArrow)){
			
			//tower = (GameObject);
			
			if(upCount==1){
				Instantiate(towerPrefab, new Vector3(1, 2, 0), Quaternion.identity);
			}
			
			if(upCount==2){
				Instantiate(towerPrefab, new Vector3(-1, 2, 0), Quaternion.identity);
			}
			
			if(upCount==3){
				Instantiate(towerPrefab, new Vector3(1, 4, 0), Quaternion.identity);
			}
			
			if(upCount==4){
				Instantiate(towerPrefab, new Vector3(-1, 4, 0), Quaternion.identity);
			}
			
			if(upCount==5){
				Instantiate(towerPrefab, new Vector3(1, 6, 0), Quaternion.identity);
			}
			
			if(upCount==6){
				Instantiate(towerPrefab, new Vector3(-1, 6, 0), Quaternion.identity);
			}
			
			upCount++;
			
		}


	}

	//void OnRightArrowDown (){
	//	tower = (GameObject);
		//	Instantiate(towerPrefab





}
