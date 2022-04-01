using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawn : MonoBehaviour
{

    public Transform enemyPrefab;
    public Transform spawnPoint;

    //subistituir por todos os inimigos morrer;
    public float timeBetweenWanves = 5f;
    private float countdown = 2f;

    private int waveNumber = 0;

    void Update()
    {
        if (countdown <= 0f)
        {
            StartCoroutine(SpawnWave());
            countdown = timeBetweenWanves;
        }
        countdown -= Time.deltaTime;
    }
    IEnumerator SpawnWave()
    {
        waveNumber += 9;

        for (int i = 0; i < waveNumber; i++)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(0.5f);
        }
        
        
    }
    
    void SpawnEnemy()
    {
        //instancia o inimigo na posição e rotação do tranform "spawnpoint"
        Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
    }
}
