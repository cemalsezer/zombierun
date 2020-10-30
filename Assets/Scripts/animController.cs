using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class animController : MonoBehaviour
{
    NavMeshAgent navMeshAgent;
    Animator animator;

    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();

    }
    
    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("playerVelocity", navMeshAgent.velocity.magnitude);   
        
    }
}
