using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    #region Singleton 
    //variavel para criar o singleton
    public static BuildManager instance;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.Log("Tem mais de um 'BuildManager' na cena! ");
            return;
        }
        instance = this;
    }
    #endregion

    public GameObject standardTurrentPrefab;
    private GameObject turrentToBuild;

   

    //função retorna a torreta para instanciar, é chamada no script "NodeTower"
    public GameObject GetTurrentToBuild()
    {
        return turrentToBuild;
    }

    public void SetTurrentBuild (GameObject turrent)
    {
        turrentToBuild = turrent;
    }

}
