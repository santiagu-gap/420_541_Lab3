using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform bulletSpawnPoint;
    public float bulletSpeed = 10f;
    public float chargeSpeed = 10f;
    private float chargeTime = 0f;

    void Update()
    {
        if (Input.GetButtonUp("Fire1"))
        {

            GameObject bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
            BulletComponent bulletComp = bullet.GetComponent<BulletComponent>();
            bulletComp.bulletSpeed = bulletComp.bulletSpeed * chargeTime;

        }
        else if (Input.GetButtonDown("Fire1"))
        {
            chargeTime = 0;
        } else if (Input.GetButton("Fire1"))
        {
            chargeTime += chargeSpeed * Time.deltaTime;
            chargeTime = Mathf.Clamp(chargeTime, 0, 3);
        }

    }


}
