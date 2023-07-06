using UnityEngine;
using UnityEngine.Events;

public class EndGame : MonoBehaviour
{
    public GameObject spawnObject;
    public UnityEvent OnCollisionEvent;

    public void OnCollisionEnter()
    {
        //spawnObject.gameObject.SetActive(false);
        OnCollisionEvent.Invoke();
    }

}
