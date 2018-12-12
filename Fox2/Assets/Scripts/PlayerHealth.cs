using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {
public SpriteRenderer playerImage;
public int HP;
public float dmgTime;
public float damageTimer;
public bool damageImmune;
public AudioSource sfx;

public Image heart1;
public Image heart2;
public Image heart3;
public Image heart4;
public bool playerDead;
public LevelLoader LevelManager;
public string currentLevel;
	// Use this for initialization
	void Start () {
		HP=4;
		damageImmune = false;
		damageTimer = dmgTime;
	}
	
	// Update is called once per frame
	void Update () {
		if(damageImmune)
		{
			//playerImage.color = Color.red;
			playerImage.color = Color.red;
			damageTimer = damageTimer - Time.deltaTime;
			if(damageTimer<=0)
			{
				damageImmune =false;
				damageTimer = dmgTime;
				playerImage.color = Color.white;
			}
		}
		
		HealthUIrefresh();
		if(HP <=0)
		{
			//signal player is dead and reload
			playerDead = true;
		}
		if(playerDead)
		{
			LevelManager.LoadLevel(currentLevel);
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
	public void HealthUIrefresh()
	{
		if(HP >=4)
		{
			heart1.enabled = true;
			heart2.enabled = true;
			heart3.enabled = true;
			heart4.enabled = true;
		}
		if(HP <4 && HP >=3)
		{
			heart1.enabled = true;
			heart2.enabled = true;
			heart3.enabled = true;
			heart4.enabled = false;
		}
		if(HP <3 && HP >=2)
		{
			heart1.enabled = true;
			heart2.enabled = true;
			heart3.enabled = false;
			heart4.enabled = false;
		}
		if(HP <2 && HP >=1)
		{
			heart1.enabled = true;
			heart2.enabled = false;
			heart3.enabled = false;
			heart4.enabled = false;
		}
		if(HP <1 && HP >=0)
		{
			heart1.enabled = false;
			heart2.enabled = false;
			heart3.enabled = false;
			heart4.enabled = false;
		}
	}

	public void Hurt()
	{	if(damageImmune)
		{}
		if(!damageImmune){
			//play sound
			sfx.Play();
			playerImage.color = Color.red;
			TakeDamage();
			damageImmune = true;		
		}
    }
}
