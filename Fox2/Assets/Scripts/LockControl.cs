using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockControl : MonoBehaviour {
public SpriteRenderer img;
public Sprite [] doors;
public bool orangeDoor;
public bool BlueDoor;
public bool greenDoor;
public bool yellowDoor;

public GameObject myCollider;
public GameObject  myImage;

public AudioSource sfx;
public bool disableWhenDone;

	// Use this for initialization
	void Start () {
		SetUpDoor();
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

	void SetUpDoor()
	{
		if(orangeDoor)
		{
			img.sprite = doors[0];
		}
		else if(BlueDoor)
		{
			img.sprite = doors[1];
		}
		else if(greenDoor)
		{
			img.sprite = doors[2];
		}
		else if(yellowDoor)
		{
			img.sprite = doors[3];
		}
	}

	void OnTriggerEnter2D(Collider2D col)
    {
		if(col.gameObject.tag =="Player")
		{
			//Check to see if player has a correct key
            if(col.gameObject.GetComponent<PlayerHealth>() !=null)
            {
                Debug.Log("The game object has a player health object");
                if (col.gameObject.GetComponent<PlayerHealth>().orangekey && orangeDoor)
                {
                    sfx.Play();
                    disableWhenDone = true;
                    myCollider.SetActive(false);
                    myImage.SetActive(false);
                    //gameObject.SetActive(false);
                }
               else if (col.gameObject.GetComponent<PlayerHealth>().Bluekey && BlueDoor)
                {
                    sfx.Play();
                    disableWhenDone = true;
                    myCollider.SetActive(false);
                    myImage.SetActive(false);
                    //gameObject.SetActive(false);
                }
                else if (col.gameObject.GetComponent<PlayerHealth>().greenkey && greenDoor)
                {
                    sfx.Play();
                    disableWhenDone = true;
                    myCollider.SetActive(false);
                    myImage.SetActive(false);
                    //gameObject.SetActive(false);
                }
                else if (col.gameObject.GetComponent<PlayerHealth>().yellowkey && yellowDoor)
                {
                    sfx.Play();
                    disableWhenDone = true;
                    myCollider.SetActive(false);
                    myImage.SetActive(false);
                    //gameObject.SetActive(false);
                }
            }



        }
    }
}
