using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] public int Hp;
    [SerializeField] private Animator _animator;
    public void Takedam(int dam)
    {
        Hp -= dam;
        if (Hp <= 0)
        {
            _animator.SetTrigger("Die");
            GetComponent<Collider>().enabled = false;
        }
        
    }
}
