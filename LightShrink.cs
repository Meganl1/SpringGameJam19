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
    if(lt.range == 0)
    {
      Destroy(transform.parent.gameObject);
    }
	}

  void OnTriggerStay2D(Collider2D collider)
	{
		 if(collider.gameObject.tag == "Home")
		 {
      //Destroy(gameObject);
			lt.range = originalRange;
      Range = originalRange;
		}
	}

  void OnTriggerEnter2D(Collider2D collider)
  {
    if(collider.gameObject.tag == "Memer")
    {
      lt.range -= 3;
    }
  }


}
