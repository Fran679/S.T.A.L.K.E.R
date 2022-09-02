using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfCollider : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        GameObject player = GameObject.Find("Player");
        if(other.gameObject.name =="Player")
        {
            Debug.Log("HOla");
        }
    }
}
