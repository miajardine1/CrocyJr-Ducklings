
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
   public void LoadScene(string eatDucklings)
   {
       SceneManager.LoadScene("EatDucklings");

   }
}
