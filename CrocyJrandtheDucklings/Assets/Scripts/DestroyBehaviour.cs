using UnityEngine;

public class DestroyBehaviour : MonoBehaviour
{
   
    public void OnCollisionEnter()
    {
      Destroy(gameObject);
    }
}
