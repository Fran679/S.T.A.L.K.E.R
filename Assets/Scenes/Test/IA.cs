using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class IA : MonoBehaviour
{

    NavMeshAgent agent;


    void Start()
    {
       agent = GetComponent<NavMeshAgent>();
        InvokeRepeating("DestinationActualization", 0, 2f);
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void FixedUpdate()
    {
    }

    void DestinationActualization()
    {
        agent.SetDestination(RedCube.posicion);
    }
}
