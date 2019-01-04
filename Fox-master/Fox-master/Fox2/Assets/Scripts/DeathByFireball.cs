using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathByFireball : MonoBehaviour {
public int health;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(health<0)
		{
			gameObject.transform.parent.gameObject.SetActive(false);
			//gameObject.SetActive(false);
		}
	}
	public void TakeDamage(int damage)
	{
		health = health-damage;
	}
}
