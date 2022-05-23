using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeTower : MonoBehaviour
{
    public Color hoverColor;
    public Vector3 positionOffset;

    [Header("Opcional")]
    public GameObject turrent;

    private Renderer rend;
    private Color startColor;

    //public Transform positionTurrent;

    BuildManager buildManager;
    private void Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;
        buildManager = BuildManager.instance;
    }

    public Vector3 GetBuildPosition ()
    {
        return transform.position + positionOffset;
    }

    private void OnMouseDown()
    {
        if (!buildManager.CanBuild)
        {
            return;
        }
        if (turrent != null)
        {
            Debug.Log("Can't build there! ");
            return;
        }

        buildManager.BuildTurrentOn(this);
    }
    private void OnMouseEnter()
    {
        if (buildManager.CanBuild)
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
