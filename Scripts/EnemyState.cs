using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;



public class EnemyState : MonoBehaviour
{
    private Transform target;
    private int danoMinion = 1;
    private float atackCooldown = 2f;
    private float minionAtack = 5;


    public NavMeshAgent agent;
    public Vector3 alvo;
    public Vector3 alvoPrincipal;
    public float campoDeVisao;
    public float campoDeAtaque;


    //barra de vida
    private int health = 100;
    public BarraDeVida barraDeVida;

    
    void Start()
    {
        //atribui a quantidade de vida que a barra de vida vai ter
        barraDeVida.SetMaxHealth(health); 
        InvokeRepeating("UpdateTarget", 0f, 1f);

    }

    
    void Update()
    {
        if (target == null)
        {
            return;
        }
        Vector3 direction = alvo - transform.position;
        if (direction.magnitude <= campoDeAtaque)
        {
            //ataque do Minion Alien, faz ele esperar 5segundos para atacar.
            
            if (atackCooldown <= 0f)
            {
                //substituir pela função de tomar dano da torreta e colônia.
                CausaDano(target);
                atackCooldown = 1f / minionAtack;
            }

            atackCooldown -= Time.deltaTime;  
        }
        

    }
    #region UpdateTarget
    void UpdateTarget()
    {
        
        //cria um array com os objetos que estiverem com a tag "inimigo"
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("aliado");

        //usa o math.infinity para ter um valor maior que a primeira distancia
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
            target = nearestEnemy.transform;
            alvo = nearestEnemy.transform.position;
            agent.SetDestination(alvo);
        }
        else
        {
            
            agent.SetDestination(alvoPrincipal);
        }
    }
    #endregion

    //função é chamada no script Bullet
    public void TomarDano (int qtdDano)
    {
        
        health -= qtdDano;
        barraDeVida.SetHealth(health);

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

    void CausaDano(Transform _torreta)
    {

        Turrent torreta = _torreta.GetComponent<Turrent>();

        if (torreta != null)
        {
            torreta.TomarDanoTorreta(danoMinion);
        }


    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(this.transform.position, campoDeVisao);
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(this.transform.position, campoDeAtaque);
    }
}

