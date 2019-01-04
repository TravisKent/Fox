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

public bool orangekey;
public bool Bluekey;
public bool greenkey;
public bool yellowkey;

public Image keyemptykey1;
public Image keyemptykey2;
public Image keyemptykey3;
public Image keyemptykey4;
    public Image keyfullkey1;
    public Image keyfullkey2;
    public Image keyfullkey3;
    public Image keyfullkey4;


    // Use this for initialization
    void Start () {
		HP=4;
		damageImmune = false;
		damageTimer = dmgTime;

        orangekey = false;
        Bluekey = false;
        greenkey = false;
        yellowkey = false;

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

        KeyImageUpdate();

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

    public void KeyCollected(int key)
    {
        if(key ==0)
        {
            orangekey = true;
        }
        if (key == 1)
        {
            Bluekey = true;
        }
        if (key == 2)
        {
            greenkey = true;
        }
        if (key == 3)
        {
            yellowkey = true;
        }
    }

    public void KeyImageUpdate()
    {
       if( orangekey)
        {
           // Debug.Log("turn on orange key");
            keyemptykey1.enabled = false;
            keyfullkey1.enabled = true;
        }
        else if (!orangekey)
        {
            //Debug.Log("turn on orange key");
            keyemptykey1.enabled = true;
            keyfullkey1.enabled = false;
        }
        if (Bluekey)
        {
            keyemptykey2.enabled = false;
            keyfullkey2.enabled = true;
        }
        else if (!Bluekey)
        {
            keyemptykey2.enabled = true;
            keyfullkey2.enabled = false;
        }
        if (greenkey)
        {
            keyemptykey3.enabled = false;
            keyfullkey3.enabled = true;
        }
        else if (!greenkey)
        {
            keyemptykey3.enabled = true;
            keyfullkey3.enabled = false;
        }
        if (yellowkey)
        {
            keyemptykey4.enabled = false;
            keyfullkey4.enabled = true;
        }
        else if (!yellowkey)
        {
            keyemptykey4.enabled = true;
            keyfullkey4.enabled = false;
        }

    }
}
