using UnityEngine;
using UnityEngine.Rendering;

public class Player : MonoBehaviour
{
    Vector3 mousePos;
    float jumpValue;
    Rigidbody2D playerRigidBody;
    Vector2 velocity;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerRigidBody = GetComponent<Rigidbody2D>();
        jumpValue = 0f;
    }

    // Update is called once per frame
    private void Update()
    {
        checkInput();
    }

    

    void checkInput()
    {
        if (Input.GetMouseButtonDown(0))
        {
            print("jumping");
            jumpValue = 10;
            jumpFunction();
        }

    }

    void jumpFunction()
    {
        velocity.Set(0, jumpValue);
        playerRigidBody.linearVelocity += velocity;
        print(playerRigidBody.linearVelocityY);
    }

    void getMousePos()
    {
        mousePos = Input.mousePosition;
    }
}
