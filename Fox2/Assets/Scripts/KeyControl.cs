using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyControl : MonoBehaviour {

public SpriteRenderer img;
public Sprite [] keys;
public bool orangekey;
public bool Bluekey;
public bool greenkey;
public bool yellowkey;

public GameObject  myImage;

public AudioSource sfx;
public bool disableWhenDone;

	// Use this for initialization
	void Start () {
		SetUpkey();
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

	void SetUpkey()
	{
		if(orangekey)
		{
			img.sprite = keys[0];
		}
		else if(Bluekey)
		{
			img.sprite = keys[1];
		}
		else if(greenkey)
		{
			img.sprite = keys[2];
		}
		else if(yellowkey)
		{
			img.sprite = keys[3];
		}
	}

	void OnTriggerEnter2D(Collider2D col)
    {
		if(col.gameObject.tag =="Player")
		{
            //Add Key To player
            //Check to see if player has a correct key
            if (col.gameObject.GetComponent<PlayerHealth>() != null)
            {
                Debug.Log("The game object has a player health object");
                if (orangekey)
                {
                    col.gameObject.GetComponent<PlayerHealth>().orangekey = orangekey;

                    sfx.Play();
                    disableWhenDone = true;
                    myImage.SetActive(false);
                    //gameObject.SetActive(false);
                }
                else if (Bluekey)
                {
                    col.gameObject.GetComponent<PlayerHealth>().Bluekey = Bluekey;

                    sfx.Play();
                    disableWhenDone = true;
                    myImage.SetActive(false);
                    //gameObject.SetActive(false);
                }
                else if (greenkey)
                {
                    col.gameObject.GetComponent<PlayerHealth>().greenkey = greenkey;

                    sfx.Play();
                    disableWhenDone = true;
                    myImage.SetActive(false);
                    //gameObject.SetActive(false);
                }
                else if (yellowkey)
                {
                    col.gameObject.GetComponent<PlayerHealth>().yellowkey = yellowkey;

                    sfx.Play();
                    disableWhenDone = true;
                    myImage.SetActive(false);
                    //gameObject.SetActive(false);
                }
            }

		}
    }
}


