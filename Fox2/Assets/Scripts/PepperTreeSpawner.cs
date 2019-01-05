using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PepperTreeSpawner : MonoBehaviour
{

    public GameObject PepperSpawn_1;
    public GameObject PepperSpawn_2;
    public GameObject PepperSpawn_3;


    public float Pepper1Timer;
    public float Pepper2Timer;
    public float Pepper3Timer;

    public float counter01;
    public float counter02;
    public float counter03;



    // Use this for initialization
    void Start()
    {
        counter01 = Pepper1Timer;
        counter02 = Pepper2Timer;
        counter03 = Pepper3Timer;

    }

    // Update is called once per frame
    void Update()
    {
        SpawnPepper();

    }

    void SpawnPepper()
    {
        CheckPepperStatus();
        if (counter01 <= 0)
        {
            PepperSpawn_1.SetActive(true);
            PepperSpawn_1.GetComponent<PepperPowerUp>().Reset();
            counter01 = Pepper1Timer;
        }
        if (counter02 <= 0)
        {
            PepperSpawn_2.SetActive(true);
            PepperSpawn_2.GetComponent<PepperPowerUp>().Reset();
            counter02 = Pepper2Timer;
        }
        if (counter03 <= 0)
        {
            PepperSpawn_3.SetActive(true);
            PepperSpawn_3.GetComponent<PepperPowerUp>().Reset();
            counter03 = Pepper3Timer;
        }
    }


    void CheckPepperStatus()
    {
       // Debug.Log("pepper one actice is :" + PepperSpawn_1.activeSelf);
        if(!PepperSpawn_1.activeSelf)
        {
            counter01 = counter01 - Time.deltaTime;
        }
        if (!PepperSpawn_2.activeSelf)
        {
            counter02 = counter02 - Time.deltaTime;
        }
        if (!PepperSpawn_3.activeSelf)
        {
            counter03 = counter03 - Time.deltaTime;
        }

    }
}
