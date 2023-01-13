using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobInstantiate : MonoBehaviour
{
    public Transform SpawnPoint;
    public GameObject MobPrefab;
    void Start()
    {
        InvokeRepeating("MobSpawn", 2, 2f);
    }

    // Update is called once per frame
    void MobSpawn ()
    {
        Instantiate(MobPrefab, SpawnPoint.position, SpawnPoint.rotation);
    }
}
