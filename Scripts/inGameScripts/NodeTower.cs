using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeTower : MonoBehaviour
{
    public Color hoverColor;
    public Vector3 positionOffset;

    private GameObject turrent;

    private Renderer rend;
    private Color startColor;

    public Transform positionTurrent;

    BuildManager buildManager;
    private void Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;
        buildManager = BuildManager.instance;
    }

    private void OnMouseDown()
    {
        if (buildManager.GetTurrentToBuild() == null)
        {
            return;
        }
        if (turrent != null)
        {
            Debug.Log("Can't build there! ");
            return;
        }

        //constroi a torreta
        GameObject turrentToBuild = buildManager.GetTurrentToBuild();
        turrent = (GameObject)Instantiate(turrentToBuild, positionTurrent.position + positionOffset, positionTurrent.rotation);
    }
    private void OnMouseEnter()
    {
        if (buildManager.GetTurrentToBuild() == null)
        {
            return;
        }
        rend.material.color = hoverColor;
    }
    private void OnMouseExit()
    {
        rend.material.color = startColor;
    }
}
