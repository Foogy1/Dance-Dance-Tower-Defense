using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class NormalProjectileMovement : MonoBehaviour {

	public Vector2 TargetPosition;
	private GameObject projectile;
	private Transform target;

	void Start () {
	
		projectile.GetComponent<NormalProjectileMovement> ().TargetPosition = target.position;

	}
	

	void Update () {
	
		transform.position = Vector2.MoveTowards (transform.position, TargetPosition, 1f);

	}
}
