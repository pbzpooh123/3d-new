using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemyattack : MonoBehaviour
{
    [SerializeField] private float timer = 5;
    private float bulletTime;
    public GameObject enemyBullet;
    public Transform spawnpoint;
    public float shootingspeed;
    private Transform player;
    [SerializeField] Animator animator;
    
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(player.position, animator.transform.position);
        if (distance < 10)
        {
            ShootAtPlayer();
        }
        

    }

    public void ShootAtPlayer()
    {
        
        bulletTime -= Time.deltaTime;
        if (bulletTime > 0) return;
        {
            bulletTime = timer;
        }

        GameObject bulletObj = Instantiate(enemyBullet, spawnpoint.transform.position, spawnpoint.transform.rotation);
        Rigidbody bulletRig = bulletObj.GetComponent<Rigidbody>();
        bulletRig.AddForce(bulletRig.transform.forward * shootingspeed,ForceMode.Impulse);
        Destroy(bulletObj, 5);

    }
    
   
}
