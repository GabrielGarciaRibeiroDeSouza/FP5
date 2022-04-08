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
        //chama esse fun��o duas vezes por segundo
        InvokeRepeating("UpdateWave", 0f, 0.5f);
    }

    void UpdateWave()
    {
        listaInimigo = GameObject.FindGameObjectsWithTag("inimigo");
    }
    void Update()
    {
        //usa esse esse if para n�o chamr mais de uma onda.
        if (countdown <= 0f)
        {
            nextWave = true;
            countdown = timeBetweenWanves;
        }
   
        countdown -= Time.deltaTime;
    }

    //essa fun��o � chama pelo click no bot�o "btnNextWave"
    public void SpawnWave()
    {
        //verifica se o array est� vazio e se "nextWave" � verdadeiro
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
        //instancia o inimigo na posi��o e rota��o do tranform "spawnpoint"
        Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
    }
}
