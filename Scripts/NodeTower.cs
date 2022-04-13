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

    private void Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;
    }

    private void OnMouseDown()
    {
        if (turrent != null)
        {
            Debug.Log("Can't build there! ");
            return;
        }

        //constroi a torreta
        GameObject turrentToBuild = BuildManager.instance.GetTurrentToBuild();
        turrent = (GameObject)Instantiate(turrentToBuild, positionTurrent.position + positionOffset, positionTurrent.rotation);
    }
    private void OnMouseEnter()
    {
        rend.material.color = hoverColor;
    }
    private void OnMouseExit()
    {
        rend.material.color = startColor;
    }
}
