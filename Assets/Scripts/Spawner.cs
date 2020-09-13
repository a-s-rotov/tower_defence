using System.Collections;
using System.Collections.Generic;
using System.Security.Permissions;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public gameObject SpawnObject;
    public float spawnTime = 1f;
    private float timer = 0;

    void Start()
    {
        
    }

    void Update()
    {
        spawnTime -= Time.deltaTime;
        if (spawnTime <= 0)
    }
}
