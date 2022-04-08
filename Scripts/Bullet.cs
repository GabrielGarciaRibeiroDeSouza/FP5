using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Transform target;

    float speed = 70f;

    public int dano = 50;
    void Start()
    {
        
    }

    
    void Update()
    {
        //se não tiver alvo vai destruir esse gameobject
        if (target == null)
        {
            Destroy(gameObject);
            return;
        }

        Vector3 direction = target.position - transform.position;
        float distanceThisframe = speed * Time.deltaTime;

        if (direction.magnitude <= distanceThisframe)
        {
            HitTarget();
            return;
        }

        transform.Translate(direction.normalized * distanceThisframe, Space.World);
    }
    //essa função é referênciada no Script "Turrent" para usar o alvo atual da torreta
    public void Perseguir (Transform _target)
    {
        target = _target;
    }

    void HitTarget()
    {
        //Destroy(target.gameObject);
        Destroy(gameObject);
        CausaDano(target);
    }
    void CausaDano(Transform enemy)
    {
        
        EnemyState inimigo = enemy.GetComponent<EnemyState>();
        
        if (inimigo != null)
        {
            inimigo.TomarDano(dano);
        }

        
    }
}
