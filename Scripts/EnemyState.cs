using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;



public class EnemyState : MonoBehaviour
{
    

    public NavMeshAgent agent;
    int casos = 0;

    public Vector3 alvo;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        switch (casos)
        {
            default:
                agent.SetDestination(alvo);
                break;
        }

    }
    

}
