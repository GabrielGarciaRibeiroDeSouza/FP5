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
    public void Vencer()
    {
        
            print("Vencemo");
        
    }
    public void GameOver()
    {
        //carrega cena de perdeu
        print("perdemo");
    }
}
