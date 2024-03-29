﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject spawnee;
    public bool stopSpawning= false;
    public float spawnTime;
    public float spawnDelay;
    public GameObject lastSpawned;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObject", spawnTime, spawnDelay);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnObject()
    {
        lastSpawned= Instantiate(spawnee, transform.position, transform.rotation);
        if (stopSpawning)
            CancelInvoke("SpawnObject");
    }
}
