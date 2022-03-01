using UnityEngine;

public class ChangeGameState : MonoBehaviour
{
    private GameObject gameOverText;
    private GameObject restartButton;
    private bool isGameActive;
    
    public void EndGame()
    {
        gameOverText.gameObject.SetActive(true);
        restartButton.gameObject.SetActive(true);
        isGameActive = false;
    }
}
