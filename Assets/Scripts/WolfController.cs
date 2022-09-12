using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class WolfController : MonoBehaviour
{
    Animator animator;
    public Transform target;
    public Transform enemy;
    public float maxRange;
    NavMeshAgent agent;
    public bool isDead=false;


    void Start()
    {
        agent = GetComponent<NavMeshAgent>();

        animator = GetComponent<Animator>();
    }

    // Update is called once per frame

    private void Update()
    {

        var heading = target.position - enemy.position;
        var distance = heading.magnitude;
        var direction = heading / distance;

        if (heading.sqrMagnitude < maxRange)
        {
            animator.SetBool("isRunning",true);
        }
        else 
        {
            animator.SetBool("isRunning", false);
        }
        IsDead();
    }
    void IsDead()
    {
        if (isDead==true)
        {
            animator.SetBool("isRunning", false);

            animator.SetBool("isDead", true);
        }
        
    }
}
