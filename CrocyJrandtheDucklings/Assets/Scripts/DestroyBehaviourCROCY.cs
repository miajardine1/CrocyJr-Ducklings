using UnityEngine;
using UnityEngine.Events;

public class DestroyBehaviourCROCY : MonoBehaviour
{
    public float seconds = 20f;
    private WaitForSeconds wfsobj;
    public UnityEvent onTriggerEvent;

    public void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
        onTriggerEvent.Invoke();
    }
}