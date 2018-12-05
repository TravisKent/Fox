using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelReset : MonoBehaviour {
public LevelLoader LM;
public string level2Load;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D(Collider2D col)
    {
		if(col.gameObject.tag == "Player")
		{
			LM.LoadLevel(level2Load);
		}
	}
}
