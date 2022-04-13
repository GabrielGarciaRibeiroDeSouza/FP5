using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    BuildManager buildManager;

    private void Start()
    {
        buildManager = BuildManager.instance;
    }

    public void PurchaseStandardTurrent ()
    {
        buildManager.SetTurrentBuild(buildManager.standardTurrentPrefab);
        Debug.Log("Torreta comprada");
    }
}
