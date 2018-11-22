using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Weapon : MonoBehaviour {
public Transform firepoint;
public GameObject firballPrefab;
public int energy;
public Slider engergySlider;

	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown(KeyCode.Space))
		{
			Shoot();
		}
		engergySlider.value = energy;
	}

	void Shoot()
	{	
		if(energy>0)
		{
			Instantiate(firballPrefab, firepoint.position, firepoint.rotation);
			energy = energy- 1;
			if(energy<0)
			{
				energy=0;
			}
		}
	}

	public void AddEnergy(int value)
	{
		energy = energy+value;
	}
}
