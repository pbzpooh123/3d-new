using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
   private void OnCollisionEnter(Collision collision)
   {
      if (collision.gameObject.CompareTag("Target"))
      {
         Destroy(gameObject);
         
      }
      
   }

   public void OnTriggerEnter(Collider other)
   {
      if (other.tag == "Enemy")
      {
         other.GetComponent<Enemy>().Takedam(10);
         Destroy(gameObject);
         SCORE.isntance.Addpoint();
      }
      if (other.tag == "Player")
      {
         other.GetComponent<Player>().Takedam(10);
         Destroy(gameObject);
         SCORE.isntance.Removepoint();
      }
   }
}
