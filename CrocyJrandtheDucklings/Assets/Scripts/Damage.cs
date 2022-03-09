using UnityEngine;


public class Damage : MonoBehaviour
{
    public int health = 50;
    public int damageInt = 10;
    public void OnCollisionEnter()
    {
        health--;
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
