using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform firePoint;
    public GameObject bulletPrefab;
    
    public bool shooting = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && !shooting)
        {
            Shoot();
            shooting = false;
        }

    }

    void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }

}
