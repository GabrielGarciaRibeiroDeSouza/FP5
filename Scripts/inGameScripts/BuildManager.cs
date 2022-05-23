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
    private TurrentBlueprint turrentToBuild;

    public bool CanBuild { get { return turrentToBuild != null; } }

    public void BuildTurrentOn (NodeTower node)
    {
        if (PlayerStats.Money < turrentToBuild.cost)
        {
            Debug.Log("Not enough money '^'");
            return;
        }
        PlayerStats.Money -= turrentToBuild.cost;

        GameObject turrent =  (GameObject)Instantiate(turrentToBuild.prefab,node.GetBuildPosition(), Quaternion.identity);
        node.turrent = turrent;

        Debug.Log("Money left: " + PlayerStats.Money);
    }
    public void SelectTurrentToBuild(TurrentBlueprint turrent)
    {
        turrentToBuild = turrent;
    }

}
