using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoboxScript : MonoBehaviour
{

    [Header("References")]
    [SerializeField] private GunData gunData;


    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        gunData.bulletCapacity = gunData.bulletCapacity + 180;
        Destroy(this.gameObject);
    }
}
