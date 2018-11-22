using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemScript : MonoBehaviour {

public AudioSource sfx;
public bool disableWhenDone;
	// Use this for initialization
	void Start () {
		disableWhenDone = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(disableWhenDone)
		{
			if(!sfx.isPlaying)
			{
				gameObject.SetActive(false);
			}
		}
	}

	void OnTriggerEnter2D(Collider2D col)
    {
		if(col.gameObject.tag =="Player")
		{
			sfx.Play();
			disableWhenDone = true;
			gameObject.GetComponent<SpriteRenderer>().enabled = false;
			gameObject.GetComponent<PolygonCollider2D>().enabled = false;
        	//gameObject.SetActive(false);
		}
    }
}
