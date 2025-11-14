using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
   public string nextSceneName;

   private void OnCollisionEnter2D(Collision2D other)
      {
         if (other.gameObject.tag == "Player")
         { 
            LoadNextLevel();
         }
      }

   private void LoadNextLevel()
   {
      SceneManager.LoadScene(nextSceneName);
   }
}