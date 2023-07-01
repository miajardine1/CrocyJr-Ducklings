using UnityEngine;

public class DestroyBehaviourCROCY : MonoBehaviour
{
   
    public void OnCollisionEnter()
    {
      Destroy(gameObject);
    }
}
