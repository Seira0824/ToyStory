using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    public Transform target;
    NavMeshAgent agent;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        agent.destination = target.position;
        float distance = Vector3.Distance(target.position, transform.position);
        animator.SetFloat("distance", distance);
        if (distance < 1)
        { //攻撃
            agent.speed = 0;
        }
        else if (distance < 4)
        {
            //追跡
            agent.speed = 2;
        }
        else
        {
            //待機
            agent.speed = 0;
        }



    }
}
