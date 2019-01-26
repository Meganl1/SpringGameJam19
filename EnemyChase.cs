using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyChase : MonoBehaviour {

	public float speed;
	public float stoppingDistance;

	private Transform target;
	
	// Use this for initialization
	void Start () {
		target = GameObject.FindGameObjectWithTag("Player").
	}

	// Update is called once per frame
	void Update () {

	}
}
