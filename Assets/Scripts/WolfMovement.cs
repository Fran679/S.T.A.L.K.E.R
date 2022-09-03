using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfMovement : MonoBehaviour
{
    public Transform target;
    public Transform enemy;
    public float maxRange;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        var heading = target.position - enemy.position;
        var distance = heading.magnitude;
        var direction = heading / distance;

        if (heading.sqrMagnitude<maxRange)
        {
            print("Target in range");
        }
    }
}
