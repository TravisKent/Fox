using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalController : MonoBehaviour {

	public Transform otherDoor;
	public AudioSource sfx;
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
        	//
			if(Input.GetKeyDown(KeyCode.E))
			{
				//warp to other door
				sfx.Play();
				col.gameObject.transform.position = otherDoor.position;
			}
		}
    }

	void OnTriggerStay2D(Collider2D col)
    {
		if(col.gameObject.tag =="Player")
		{
       //
			if(Input.GetKeyDown(KeyCode.E))
			{
				//warp to other door
				sfx.Play();
				col.gameObject.transform.position = otherDoor.position;
			}
		}
    }
	void OnTriggerExit2D(Collider2D col)
    {
		if(col.gameObject.tag =="Player")
		{
        	//

		}
    }
}
