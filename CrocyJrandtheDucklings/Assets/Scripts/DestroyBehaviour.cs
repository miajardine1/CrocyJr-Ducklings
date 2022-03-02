using UnityEngine;

public class DestroyBehaviour : MonoBehaviour
{
    public GameObject gameObj;
    private void OnTriggerEnter(Collider other)
    {
      
        Destroy(gameObj, (float) 1.5);
    }
}
