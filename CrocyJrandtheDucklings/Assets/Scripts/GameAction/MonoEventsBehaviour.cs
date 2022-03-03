using UnityEngine;
using UnityEngine.Events;

public class MonoEventsBehaviour : MonoBehaviour
{
    public UnityEvent collisionEvent;

    public void OnCollisionEnter(Collision other)
    {
        collisionEvent.Invoke();
    }
}
