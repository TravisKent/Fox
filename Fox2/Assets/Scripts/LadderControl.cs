using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LadderControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D col)
    {
		if(col.gameObject.tag =="Player")
		{
        	col.gameObject.GetComponent<PlayerMovement>().onLadder = true;
		}
    }

	void OnTriggerStay2D(Collider2D col)
    {
		if(col.gameObject.tag =="Player")
		{
        col.gameObject.GetComponent<PlayerMovement>().onLadder = true;
		}
    }
	void OnTriggerExit2D(Collider2D col)
    {
		if(col.gameObject.tag =="Player")
		{
        	col.gameObject.GetComponent<PlayerMovement>().NotClimbing();

		}
    }
}
