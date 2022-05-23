using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public TurrentBlueprint standardTurrent;
    //public TurrentBlueprint misselLanch;
    BuildManager buildManager;

    private void Start()
    {
        buildManager = BuildManager.instance;
    }

    public void SelectStandardTurrent ()
    {
        buildManager.SelectTurrentToBuild(standardTurrent);
        Debug.Log("Torreta selecionada");
    }
}
