
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    public GameObject spawnObject;
    public GameObject titleScreen;

    public void Start()
    {
        titleScreen.SetActive(false);
        spawnObject.gameObject.SetActive(true);
    }

}

  
