using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField] public GameOver GameOver;
    [SerializeField] public int Hp;
    [SerializeField] public Slider Hpbar;
    void start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
    // Start is called before the first frame update
    public void Takedam(int dam)
    {
        Hp -= dam;
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
        Hpbar.value = Hp;

        if (GameOver.isActiveAndEnabled)
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
        else
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
        
        if (Hp <= 0)
        {
            Gameoversceen();
        }
        
        
    }

    void Gameoversceen()
    {
        GameOver.Setup();
    }
}
