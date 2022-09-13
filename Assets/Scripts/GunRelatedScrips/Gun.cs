using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.PostProcessing;


public class Gun : MonoBehaviour
{

    [Header("References")]
    [SerializeField] private GunData gunData;
    [SerializeField] private Transform cam;
    [SerializeField] private Transform cañon;
    public PostProcessVolume prostp;
    private Vignette _vignette;

    public GameObject muzzle;

    float timeSinceLastShot;

    private void Start()
    {
        PlayerShoot.shootInput += Shoot;
        PlayerShoot.reloadInput += StartReload;
        prostp= gameObject.GetComponent<PostProcessVolume>();
        prostp.profile.TryGetSettings(out _vignette);
        
    }

    private void OnDisable() => gunData.reloading = false;

    public void StartReload()
    {
        if (!gunData.reloading && this.gameObject.activeSelf)
            StartCoroutine(Reload());
    }

    private IEnumerator Reload()
    {
        gunData.reloading = true;

        yield return new WaitForSeconds(gunData.reloadTime);

        if (gunData.bulletCapacity < gunData.magSize)
        {
            gunData.currentAmmo = gunData.bulletCapacity;
        }
        else
        {
            gunData.currentAmmo = gunData.magSize;
        }


        gunData.reloading = false;
    }

    private bool CanShoot() => !gunData.reloading && timeSinceLastShot > 1f / (gunData.fireRate / 60f);

    private void Shoot()
    {
        if (gunData.currentAmmo > 0 && gunData.bulletCapacity >0)
        {
            if (CanShoot())
            {
                if (Physics.Raycast(cañon.position, cañon.forward, out RaycastHit hitInfo, gunData.maxDistance))
                {
                    IDamageable damageable = hitInfo.transform.GetComponent<IDamageable>();
                    damageable?.TakeDamage(gunData.damage);
                    print(hitInfo.transform.name);

                    if (hitInfo.transform.name == "Weir Ball")
                    {   
                        print("U cant shoot this");
                    }

                }

                gunData.currentAmmo--;
                gunData.bulletCapacity--;
                timeSinceLastShot = 0;
                OnGunShot();
            }
        }
    }

    private void Update()
    {
        timeSinceLastShot += Time.deltaTime;

        Debug.DrawRay(cañon.position, cañon.forward * gunData.maxDistance);
    }

    public void OnGunShot()
    {
        Vector3 direccion = muzzle.transform.position - muzzle.transform.position;

        GameObject currentBullet = Instantiate(gunData.bulletType, muzzle.transform.position, Quaternion.identity);
        currentBullet.transform.forward = cam.forward.normalized;
        currentBullet.GetComponent<Rigidbody>().AddForce(cam.forward.normalized * gunData.bulletSpeed, ForceMode.Impulse);

        float factor = 0.05f;
        _vignette.intensity.value += 0.025f;
        //currentBullet.transform.rotation =Quaternion.Euler(90,0,0);
        //cam.forward.normalized
        //Quaternion.Euler(90,0,0);

        //Physics.BoxCast    CHECK LATER

    }

 
}
