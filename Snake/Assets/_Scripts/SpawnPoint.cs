using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour {

    public static bool nextSpawn = true;
    public GameObject pickup;

    public static float xLimit;
    public static float ylimit;

	void Start () {
        GameManager.CreatePlayer(transform.position);
	}
	
	void Update ()
    {
        if (nextSpawn)
        {
            Vector3 spawnPoint = new Vector3(Random.Range(-20, 20), Random.Range(-11, 11), 0.0f);
            Instantiate(pickup, spawnPoint, Quaternion.identity);
            nextSpawn = false;
        }
    }
}
