using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using StarterAssets;

public class Weapon : MonoBehaviour
{
    private StarterAssetsInputs _input;
    public GameObject bulletPrefeb;

    public Transform bulletPoint;

    public float bulletVelocity = 30f;

    public float bulletLifetime = 3f;

    void Start()
    {
        _input = transform.root.GetComponent<StarterAssetsInputs>();
    }
    // Update is called once per frame
    void Update()
    {
        if (_input.shoot)
        {
            FireWeapon();
            _input.shoot = false;
        }
        
    }

    private void FireWeapon()
    {
        GameObject bullet = Instantiate(bulletPrefeb, bulletPoint.position , quaternion.identity);
        
        bullet.GetComponent<Rigidbody>().AddForce(bulletPoint.forward.normalized * bulletVelocity, ForceMode.Impulse);

        StartCoroutine(DestroyBulletAfterTime(bullet, bulletLifetime));
    }

    private IEnumerator DestroyBulletAfterTime(GameObject bullet , float delay)
    {
        yield return new WaitForSeconds(delay);
        Destroy(bullet);
    }
    
}
