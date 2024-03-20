using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
   void start()
   {
      Cursor.visible = false;
      Cursor.lockState = CursorLockMode.Locked;
   }
   
   public void Setup()
   {
      gameObject.SetActive(true);
   }

   public void Restart()
   {
      SceneManager.LoadScene("Playground");
   }

   public void ExitButton()
   {
      Application.Quit();
   }
   
}
