using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {
public int HP;
public bool playerDead;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(HP <=0)
		{
			//signal player is dead and reload
			playerDead = true;
		}
	}

	public void TakeDamage()
	{
		HP = HP-1;
	}
	public void RecoverHealth()
	{
		HP = HP+1;
	}
}
