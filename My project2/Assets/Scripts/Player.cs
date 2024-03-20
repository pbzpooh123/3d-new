using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField] public int Hp;
    [SerializeField] public Slider Hpbar;
    // Start is called before the first frame update
    public void Takedam(int dam)
    {
        Hp -= dam;
        
        
    }

    // Update is called once per frame
    void Update()
    {
        Hpbar.value = Hp;
    }
}
