using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class LoadSceneBehaviour : MonoBehaviour
{
    public UnityEvent loadSceneEvent, loadSceneEventExit;
    public void LoadScene(String sceneName)
    {
        loadSceneEvent.Invoke();
        loadSceneEventExit.Invoke();
        SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
    }
}
