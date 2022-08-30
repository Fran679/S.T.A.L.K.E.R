using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName="Gun", menuName="Weapon/Gun")]
public class GunData : ScriptableObject {

    [Header("Info")]
    public new string name;

    [Header("Shooting")]
    public float damage;
    public float maxDistance;

    [Header("Specifications")]
    public GameObject bulletType;
    public int bulletSpeed;
    public GameObject backPoint;

    [Header("Gun Parts")]
    public GameObject muzzle;
    
    [Header("Reloading")]

    public int currentAmmo;
    public int magSize;
    [Tooltip("In RPM")] 

    public float fireRate;
    public float reloadTime;

    [HideInInspector] 
    public bool reloading;
    
}
