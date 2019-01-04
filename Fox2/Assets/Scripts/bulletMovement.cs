using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletMovement : MonoBehaviour {
public float speed= 20;
public int damageValue=1;
public float bulletLife = 6.0f;
public Rigidbody2D rb;
	// Use this for initialization
	void Start () {
		rb.velocity = transform.right *speed;
	}
	
	// Update is called once per frame
	void Update () {
		bulletLife = bulletLife-Time.deltaTime;
		if(bulletLife<0)
		{
			Destroy(gameObject);
		}
	}
	void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Enemy" || col.gameObject.tag == "boss"  )
		{
			//do something
			col.gameObject.GetComponent<DeathByFireball>().TakeDamage(damageValue);
			Destroy(gameObject);
		}
		else{
			//destroy fireball
			//Destroy(gameObject);
		}
	}
}
