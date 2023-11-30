using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCollider : MonoBehaviour
{
   public GameObject panel1;
   public GameObject panel2;
   public GameObject panelgagal;
   public float nyawa = 2f;

   private void  Update() 
   {
      GameOver();
   }

private void OnTriggerEnter(Collider other) 
    {
      if (other.gameObject.tag == "MisiSatu")
        {
            Debug.Log ("berhasil " );
            panel1.SetActive(true);
            PauseGame();
        }
      if (other.gameObject.tag == "MisiDua")
        {
            Debug.Log ("berhasil 2 " );
            panel2.SetActive(true);
            PauseGame();
        }
    }
      private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Pembatas")
        {
            Debug.Log ("tabrakan berhasil" );
            nyawa--;
            Debug.Log ("nyawa:" + nyawa);
        }
    }

      void GameOver()
      {
         if (nyawa == 0f)
         {
            panelgagal.SetActive(true);
            PauseGame();
         }
      }
     public void PauseGame()
    {
        Time.timeScale = 0f;
    }
    
     public void ResumeGame()
    {
        Time.timeScale = 1f;
    }
}
   

