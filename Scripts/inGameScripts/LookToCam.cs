using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookToCam : MonoBehaviour
{
    //esse script é usado no canva world space que for acompanhar a camera

    public Camera cam;

    private void Start()
    {
       cam = FindObjectOfType<Camera>(); 
    }
    void Update()
    {
        LookCamera();
    }
    private void LookCamera()
    {
        Vector3 camDirection = cam.transform.position - transform.position;
        camDirection.x = camDirection.z = 0.0f;
        transform.LookAt(cam.transform.position - camDirection);
        transform.rotation = (cam.transform.rotation);
    }
}
