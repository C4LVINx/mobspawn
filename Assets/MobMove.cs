using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MobMove : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;

    private NavMeshAgent mob;
    void Awake()
    {
        mob = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        mob.destination = playerTransform.position;
    }
}
