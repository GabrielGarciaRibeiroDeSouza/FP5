using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;



public class EnemyState : MonoBehaviour
{
    

    public NavMeshAgent agent;
    int casos = 0;
    public int health = 100;

    public Vector3 alvo;
    void Start()
    {
        
    }

    
    void Update()
    {
        

        switch (casos)
        {
            default:
                agent.SetDestination(alvo);
                break;
        }

    }
    
    public void TomarDano (int qtdDano)
    {
        health -= qtdDano;

        if (health <= 0)
        {
            Morreu();
        }
    }

    void Morreu()
    {
        //nessa função pode adicionar recompesa de moedas posteriormente

        Destroy(gameObject);
    }
}

