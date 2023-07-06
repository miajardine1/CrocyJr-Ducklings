using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class MovementBehaviour : MonoBehaviour
{
    private CharacterController charctrl;
    private Vector3 movement;
    public float speed;
    public float jumpHeight = 4f;
    public float gravity = 7f;
    private int jumpCount = 0;
    private int jumpCountMax = 2;
    
   
    private void Awake()
    {
        charctrl = GetComponent<CharacterController>();
    }
    
    /*private void Update()
    {
        // Move the character controller using the movement vector
        charctrl.Move(movement * Time.deltaTime);
        
    }*/
    
    public void onMoveRight()
    {
        movement = Vector3.zero;
        movement += Vector3.right * speed * Time.deltaTime;
        charctrl.Move(movement);
        Debug.Log("Move right");
        movement.y -= (gravity * Time.deltaTime) * 2;
    }

    public void onMoveLeft()
    {
        movement = Vector3.zero;
        movement += Vector3.left * speed * Time.deltaTime;
        charctrl.Move(movement);
        Debug.Log("Move left");
        movement.y -= (gravity * Time.deltaTime) * 2;
    }

    public void onJump()
    {
        if (jumpCount < jumpCountMax)
        {
            movement.y = jumpHeight;
            jumpCount++;
            Debug.Log("Jump began");
        }
    }

    

    
}