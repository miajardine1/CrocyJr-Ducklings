
using System.Collections;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    public GameObject spawnObject;
    public GameObject titleScreen;

    public void OnEnable()
    {
        titleScreen.SetActive(false);
        spawnObject.gameObject.SetActive(true);
    }
}

  
