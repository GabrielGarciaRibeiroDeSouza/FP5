using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quitGame : MonoBehaviour
{
    
    public void Exit()
    {
        //só funciona na versão "buildada"
        Debug.Log("Saiu do jogo");
        Application.Quit();
    }
}
