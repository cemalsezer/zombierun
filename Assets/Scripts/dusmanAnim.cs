using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class dusmanAnim : MonoBehaviour
{
    Animator animator;
    NavMeshAgent navMeshAgent;
   

    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("zombieVelocity", navMeshAgent.velocity.magnitude);
    }
}
