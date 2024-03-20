using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    [SerializeField] public int Hp;
    [SerializeField] private Animator _animator;
    [SerializeField] public Slider Hpbar;
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

    public void Takedam(int dam)
    {
        Hp -= dam;
        if (Hp <= 0)
        {
            _animator.SetTrigger("Die");
            GetComponent<Collider>().enabled = false;
            SCORE.isntance.Killpoint();
        }
        
    }

    void Update()
    {
        float distance = Vector3.Distance(player.position, animator.transform.position);
        if (distance < 10)
        {
            if (Hp > 0)
            {
                ShootAtPlayer();
            }
           
        }
        Hpbar.value = Hp;
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
        Destroy(bulletObj, 2);

    }
}
