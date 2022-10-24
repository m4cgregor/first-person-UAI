using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class navmeshagent : MonoBehaviour
{
    public NavMeshAgent agent;
    private Transform target;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
        agent = GetComponent<NavMeshAgent>();
        InvokeRepeating(nameof(SetDestination), 3f, 1f);
        
    }

    // Update is called once per frame
    void Update()
    {

        SetDestination();
        
    }

    private void SetDestination()
    {

        agent.destination = target.position;

    }
}
