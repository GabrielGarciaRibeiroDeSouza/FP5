using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;



public class EnemyState : MonoBehaviour
{
    private Transform target;
    public int danoMinion = 1;

    public float fireRate = 1f;
    private float fireCountdown = 0f;

    private bool torreFinal = false;

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
        //cria o direction para medir a distancia no if
        Vector3 direction = alvo - transform.position;
        if (direction.magnitude <= campoDeAtaque)
        {
            Debug.Log("bool TorreFinal = " + torreFinal);
            //ataque do Minion Alien, faz ele esperar 5segundos para atacar.
            if (fireCountdown <= 0f && torreFinal == false)
            {
                //substituir pela função de tomar dano da torreta e colônia.

                CausaDanoTorreta(target);
                fireCountdown = 1f / fireRate;
                Debug.Log("esperando lo ataque: ");
            }

            if (fireCountdown <= 0f && torreFinal == true)
            {
                Debug.Log("torre final Toma dano");
                //substituir pela função de tomar dano da torreta e colônia.
                CausaDanoColonia(target);

                fireCountdown = 1f / fireRate;
            }
            //tiro da arma
            //if (fireCountdown <= 0f)
            //{
                
            //    fireCountdown = 1f / fireRate;
            //}

            fireCountdown -= Time.deltaTime;

        }
        

    }
    
    #region UpdateTarget
    void UpdateTarget()
    {
        
        //cria um array com os objetos que estiverem com a tag "aliado"
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("aliado");
        GameObject[] _torreFinal = GameObject.FindGameObjectsWithTag("torreFinal");
        


        //usa o math.infinity para ter um valor maior que a primeira distancia
        float shortestDistance = Mathf.Infinity;
        GameObject nearestEnemy = null;

        float shortestDistanceToFinal = Mathf.Infinity;
        GameObject nearestTorreFinal = null;

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
        foreach (GameObject goTorreFinal in _torreFinal)
        {
            float distanTorreFinal = Vector3.Distance(transform.position, goTorreFinal.transform.position);

            if (distanTorreFinal < shortestDistanceToFinal)
            {
                shortestDistanceToFinal = distanTorreFinal;
                nearestTorreFinal = goTorreFinal;
            }
        }

        if (nearestEnemy != null && shortestDistance <= campoDeVisao)
        {
            
            torreFinal = false;
            //esse target é usado no update
            target = nearestEnemy.transform;
            alvo = nearestEnemy.transform.position;
            agent.SetDestination(alvo);
            
        }
        if (nearestTorreFinal!= null && shortestDistanceToFinal < shortestDistance)
        {
            nearestEnemy = nearestTorreFinal;

            torreFinal = true;
            //esse target é usado no update
            target = nearestEnemy.transform;
            alvo = nearestEnemy.transform.position;
            agent.SetDestination(alvo);
        }
        
        
        //else
        //{

        //    agent.SetDestination(alvoPrincipal);
        //}
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

    
    void CausaDanoTorreta(Transform _torreta)
    {
        
        Turrent torreta = _torreta.GetComponent<Turrent>();

        if (torreta != null)
        {
            torreta.TomarDanoTorreta(danoMinion);
        }


    }
    void CausaDanoColonia(Transform _colonia)
    {
       
        Colonia colonia = _colonia.GetComponent<Colonia>();

        if (colonia != null)
        {
            Debug.Log(" dano: " + danoMinion);
            colonia.TomarDanoColonia(danoMinion);
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

