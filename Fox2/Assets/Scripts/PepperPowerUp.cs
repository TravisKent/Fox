using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PepperPowerUp : MonoBehaviour {

	// Use this for initialization
	public AudioSource sfx;
	public bool disableWhenDone;
	void Start () {
		
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
        if(col.gameObject.tag == "Player")
		{
			//play sound
			sfx.Play();
			disableWhenDone = true;
			gameObject.GetComponent<SpriteRenderer>().enabled = false;
			gameObject.GetComponent<CircleCollider2D>().enabled = false;	
			//gameObject.SetActive(false);
			
			//turn on fireball power
			col.gameObject.GetComponent<Weapon>().enabled = true;
			col.gameObject.GetComponent<Weapon>().AddEnergy(15);
			
		}
    }

    public void Reset()
    {
        disableWhenDone = false;
        gameObject.GetComponent<SpriteRenderer>().enabled = true;
        gameObject.GetComponent<CircleCollider2D>().enabled = true;
    }
}
