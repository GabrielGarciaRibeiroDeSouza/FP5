using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    private void Awake()
    {
        if (!Instance)
        {
            Instance = this;
        }
    }
    public void Vencer(int condicaoVitoria)
    {
        if (condicaoVitoria == 5)
        {
            print("Vencemo");
        }
    }
    void GameOver()
    {
        //carrega cena de perdeu
        print("perdemo");
    }
}
