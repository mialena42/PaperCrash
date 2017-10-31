using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerPowerUp : MonoBehaviour {
    float tiempoSpawn;
    public GameObject powerUp;
	// Use this for initialization
	void Start () {
        tiempoSpawn = 10f;
	}
	
	// Update is called once per frame
	void Update () {
        tiempoSpawn = tiempoSpawn - Time.deltaTime;
        if (tiempoSpawn<=0)
        {
            Instantiate(powerUp, gameObject.transform.position, Quaternion.identity);
            tiempoSpawn = 10f;
        }
	}
}
