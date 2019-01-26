using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightShrink : MonoBehaviour {
public float decreaseRate;
Light lt;
 float originalRange;
 float Range;
	// Use this for initialization
	void Start () {
		lt = GetComponent<Light>();
    Range = lt.range;
		originalRange = lt.range;
	}

	// Update is called once per frame
	void Update () {
		lt.range -= decreaseRate/1000;
	}

  void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Home"))
		{
			lt.range = 15;
      Range = originalRange;
		}
	}
}
