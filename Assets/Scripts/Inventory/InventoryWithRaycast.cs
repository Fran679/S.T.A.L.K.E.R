using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryWithRaycast : MonoBehaviour
{
    private int rayMaxDistance = 1         ;
    public Transform playerPosition;
    public Transform wolfPosition;
    private int wolfDetectionDistance = 3;
    private void FixedUpdate()
    {
        Debug.DrawRay(playerPosition.position, playerPosition.forward * rayMaxDistance);
        Debug.DrawLine(playerPosition.position, wolfPosition.position );
    }
    void Update()
    {
        if (Physics.Raycast(playerPosition.position, playerPosition.forward, out RaycastHit hitInfo, rayMaxDistance))
        {
            if ( hitInfo.transform.tag =="pickable")
            {
                print("pickable obj");
            }
            
        }
        if (Physics.Raycast(playerPosition.position, wolfPosition.position, out RaycastHit info, wolfDetectionDistance))
        {
            if (info.distance < wolfDetectionDistance)
            {
                print("Te vio el lobo");
            }
        }
    }
}
