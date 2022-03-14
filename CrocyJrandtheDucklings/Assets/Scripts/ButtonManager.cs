using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class ButtonManager : MonoBehaviour
{
   public TextMeshProUGUI scoreText;
   public TextMeshProUGUI gameOverText;
 

   public GameObject titleScreen;
   public Button restartButton;

   

   private int score;
   private float time;
   private float spawnRate = 3f;
   public bool isGameActive;



   private Button startButton;

   

   public void Start()
   {
      startButton = GetComponent<Button>();
      isGameActive = true;
      score = 0;
      UpdateScore(0);
      titleScreen.SetActive(false);
      Debug.Log("game start");
   }
   public void GameOver()
   {
      gameOverText.gameObject.SetActive(true);
      restartButton.gameObject.SetActive(true);
      isGameActive = false;
   }
  
   
   public void RestartGame()
   {
      SceneManager.LoadScene(SceneManager.GetActiveScene().name);
   }

   public void UpdateScore(int scoreToAdd)
   {
      score += scoreToAdd;
      scoreText.text = "Score: " + score;
   }

   
    

   
   }



