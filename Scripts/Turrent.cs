using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turrent : MonoBehaviour
{
    private Transform alvo;
    public float campoDeVisao = 15f;

    public Transform eixoRotativo;
    public float turnSpeed;

    void Start()
    {
        //chama o metodo 2 vezes por segundo
        InvokeRepeating("UpdateTarget", 0f, 0.5f);
    }

    void Update()
    {
        if (alvo == null)
        {
            eixoRotativo.rotation = Quaternion.Euler(0f, 180f, 0f);
            return;
        }
        //rota��o da torreta
        Vector3 direction = alvo.position - transform.position;
        Quaternion lookRotation = Quaternion.LookRotation(direction);
        Vector3 rotation = Quaternion.Lerp(eixoRotativo.rotation, lookRotation, Time.deltaTime * turnSpeed).eulerAngles;
        eixoRotativo.rotation = Quaternion.Euler(rotation);
        
    }

    //esse metodo busca o alvo mais pr�ximo dentro do campo de vis�o.
    void UpdateTarget()
    {
        //cria um array com os objetos que estiverem com a tag "inimigo"
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("inimigo");

        float shortestDistance = Mathf.Infinity;
        GameObject nearestEnemy = null;


        foreach (GameObject enemy in enemies)
        {

            float distanceToEnemy = Vector3.Distance(transform.position, enemy.transform.position);
            
            //se a distancia atual for menor que a anterior, define o objeto atual como a menor distancia
            if (distanceToEnemy < shortestDistance)
            {
                shortestDistance = distanceToEnemy;
                nearestEnemy = enemy;
            }
        }

        if (nearestEnemy != null && shortestDistance <= campoDeVisao)
        {
            alvo = nearestEnemy.transform;
        }
        else
        {
            alvo = null;
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(this.transform.position, campoDeVisao);
    }
}
