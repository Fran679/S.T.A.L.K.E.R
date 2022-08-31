using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim : MonoBehaviour
{
    public Transform trGun;

    private Vector3 v3;
    private float f;

    public Vector3 posNormal;
    public Vector3 posApuntando;
    public float fovApuntando;
    public float fovNormal;
    public Camera cam;
    public float velApuntar;
    private void Start()
    {
        cam = Camera.main;
    }
    private void Update()
    {
        if (Input.GetKey("mouse 1"))
        {
            trGun.localPosition = Vector3.SmoothDamp(trGun.localPosition, posApuntando, ref v3, velApuntar);
            cam.fieldOfView = Mathf.SmoothDamp(cam.fieldOfView, fovApuntando, ref f, velApuntar);
        }
        else
        {
            trGun.localPosition = Vector3.SmoothDamp(trGun.localPosition, posNormal, ref v3, velApuntar);
            cam.fieldOfView = Mathf.SmoothDamp(cam.fieldOfView, fovNormal, ref f, velApuntar);


        }
    }
}
