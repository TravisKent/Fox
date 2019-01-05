using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Ghosts : MonoBehaviour {

    public Transform GhostSpawn_1;
    public Transform GhostSpawn_2;
    public Transform GhostSpawn_3;
    public GameObject GhostPrefab;

    public float ghost1Timer;
    public float ghost2Timer;
    public float ghost3Timer;

    public float counter01;
   public float counter02;
   public float counter03;

    // Use this for initialization
    void Start () {
        counter01 = ghost1Timer;
        counter02 = ghost2Timer;
        counter03 = ghost3Timer;

    }
	
	// Update is called once per frame
	void Update () {
        SpawnGhost();

    }

    void SpawnGhost()
    {
        counter01 = counter01 - Time.deltaTime;
        counter02 = counter02 - Time.deltaTime;
        counter03 = counter03 - Time.deltaTime;
        if (counter01 <= 0)
        {
            Instantiate(GhostPrefab, GhostSpawn_1.position, GhostSpawn_1.rotation);

            counter01 = ghost1Timer;
        }
        if (counter02 <= 0)
        {
            Instantiate(GhostPrefab, GhostSpawn_2.position, GhostSpawn_2.rotation);

            counter02 = ghost2Timer;
        }
        if (counter03 <= 0)
        {
            Instantiate(GhostPrefab, GhostSpawn_3.position, GhostSpawn_3.rotation);

            counter03 = ghost3Timer;
        }
    }
}
