using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawn : MonoBehaviour
{

    public Transform enemyPrefab;
    public Transform spawnPoint;

    public GameObject[] listaInimigo;

    
    public float timeBetweenWanves = 5f;
    private float countdown = 2f;

    private bool nextWave = true;
    private int waveNumber = 1;


    private void Start()
    {
        //chama esse função duas vezes por segundo
        InvokeRepeating("UpdateWave", 0f, 0.5f);
    }

    void UpdateWave()
    {
        listaInimigo = GameObject.FindGameObjectsWithTag("inimigo");
    }
    void Update()
    {
        //usa esse esse if para não chamr mais de uma onda.
        if (countdown <= 0f)
        {
            nextWave = true;
            countdown = timeBetweenWanves;
        }
   
        countdown -= Time.deltaTime;
    }

    //essa função é chama pelo click no botão "btnNextWave"
    public void SpawnWave()
    {
        //verifica se o array está vazio e se "nextWave" é verdadeiro
        if (listaInimigo.Length <= 0 && nextWave)
        {
            waveNumber += waveNumber;

            for (int i = 0; i < waveNumber; i++)
            {
                SpawnEnemy();

            }
            nextWave = false;
        }     
    }
   
    void SpawnEnemy()
    {
        //instancia o inimigo na posição e rotação do tranform "spawnpoint"
        Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
    }
}
