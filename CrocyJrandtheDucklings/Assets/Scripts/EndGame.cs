using UnityEngine;

public class EndGame : MonoBehaviour
{
    public GameObject spawnObject;
    public GameObject gameOverScreen;

    public void OnCollisionEnter()
    {
        gameOverScreen.SetActive(true);
        spawnObject.gameObject.SetActive(false);
    }

}
