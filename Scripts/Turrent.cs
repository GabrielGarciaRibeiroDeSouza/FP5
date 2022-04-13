using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turrent : MonoBehaviour
{
    private Transform alvo;

    //entre os [] vai criar uma "se��o" no inspector com as variaveis p�blicas abaixo
    [Header("Status da Arma")]
    public float campoDeVisao = 15f;
    public float fireRate = 1f;
    private float fireCountdown = 0f;


    [Header("Configura��o da Arma")]
    public Transform eixoRotativo;
    public float turnSpeed;

    public GameObject bulletPrefab;
    public Transform firePoint;
    
    void Start()
    {
        //chama o metodo 2 vezes por segundo
        InvokeRepeating("UpdateTarget", 0f, 0.5f);
    }

    void Update()
    {
        if (alvo == null)
        {
            //eixoRotativo.rotation = Quaternion.Euler(0f, 180f, 0f);
            //eixoRotativo.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 0, 0), Time.deltaTime);
            return;
        }
        //rota��o da torreta
        Vector3 direction = alvo.position - transform.position;
        Quaternion lookRotation = Quaternion.LookRotation(direction);
        Vector3 rotation = Quaternion.Lerp(eixoRotativo.rotation, lookRotation, Time.deltaTime * turnSpeed).eulerAngles;
        eixoRotativo.rotation = Quaternion.Euler(rotation);

        //tiro da arma
        if (fireCountdown <= 0f)
        {
            Shoot();
            fireCountdown = 1f / fireRate;
        }

        fireCountdown -= Time.deltaTime;
    }

    //fun��o para fazer atirar a bala
    void Shoot()
    {
        GameObject bulletGo = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Bullet bullet = bulletGo.GetComponent<Bullet>();

        if (bullet != null)
        {
            bullet.Perseguir(alvo);
        }
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
