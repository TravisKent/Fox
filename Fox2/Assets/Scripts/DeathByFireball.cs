using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathByFireball : MonoBehaviour {
public int health;
    public bool reward;
    public Transform rewardSP;
    public GameObject RewardGameObject;
    public AudioSource sfx;
    public SpriteRenderer badguyImage;
    public bool damageImmune;
    public float dmgTime;
    public float damageTimer;
    // Use this for initialization
    void Start () {
        badguyImage = GetComponent<SpriteRenderer>();
        sfx = GetComponent<AudioSource>();
        damageImmune = false;
    }
	
	// Update is called once per frame
	void Update () {
        

        if (damageImmune)
        {
            //playerImage.color = Color.red;
            badguyImage.color = Color.red;
            damageTimer = damageTimer - Time.deltaTime;
            if (damageTimer <= 0)
            {
                damageImmune = false;
                damageTimer = dmgTime;
                badguyImage.color = Color.white;
            }
        }

        if (health<0)
		{
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
            gameObject.GetComponent<PolygonCollider2D>().enabled = false;

            if (!sfx.isPlaying)
            {
                // gameObject.SetActive(false);
                if (reward)
                {
                    SpawnReward();
                }
                gameObject.transform.parent.gameObject.SetActive(false);
            }

            
			//gameObject.SetActive(false);
		}
	}
    public void TakeDamage(int damage)
    {
        if (damageImmune)
        { }

        if (!damageImmune)
        {
            health = health - damage;
            if (gameObject.tag == "boss")
            {
                gameObject.transform.localScale = gameObject.transform.localScale - new Vector3(0.5f, 0.5f, 0.5f);
            }
            sfx.Play();
            badguyImage.color = Color.red;
            //TakeDamage();
            damageImmune = true;
        }
    }
    public void SpawnReward()
    {
       GameObject prize =  Instantiate(RewardGameObject, rewardSP);
        prize.transform.SetParent(null);
    }

   
}
