using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;
using Unity.Mathematics;

public class shoot : MonoBehaviour
{
    private StarterAssetsInputs input;
    public GameObject bulletPrefeb;

    public Transform bulletPoint;

    public float bulletVelocity = 30f;

    public float bulletLifetime = 3f;

    void Start()
    {
        input = transform.root.GetComponent<StarterAssetsInputs>();
    }
    // Update is called once per frame
    void Update()
    {
        if (input.shoot)
        {
            Debug.Log("Shoot");
            FireWeapon();
            input.shoot = false;
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
