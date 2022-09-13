using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    Light light;
    void Start()
    {
        light = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
      if(  Input.GetKey(KeyCode.F))
        {
            light.range = light.range - 1;
            light.spotAngle = light.spotAngle + 1;
            light.intensity = light.intensity - .1f;
        }
        if (Input.GetKey(KeyCode.C))
        {
            light.range = light.range + 1;
            light.spotAngle = light.spotAngle - 1;
            light.intensity = light.intensity +.1f;

        }
    }
}
