using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Safety : MonoBehaviour {
	//public GameObject player;
	public float attackRate;
	float originalRange;
	float Range;
	Light lite;
	CircleCollider2D circol;
	// Use this for initialization
	void Start () {
		lite = GetComponent<Light>();
		Range = lite.range;
		originalRange = lite.range;
		circol = gameObject.GetComponent<CircleCollider2D>();
	}

	// Update is called once per frame
	void Update () {

	}
void OnTriggerStay2D(Collider2D collider) {
	if(collider.gameObject.tag == "Homer")
	{
	
	 //Destroy(this.gameObject);
	 lite.range -= attackRate/1000;
	 circol.radius -= attackRate/125;

}

}
}
