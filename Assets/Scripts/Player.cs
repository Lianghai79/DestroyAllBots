using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    Vector2 mousePos;
    Vector2 direction;
    Vector2 location;
    float jumpValue;
    Rigidbody2D playerRigidBody;
    public Camera cam;
    Vector2 velocity;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerRigidBody = GetComponent<Rigidbody2D>();
        jumpValue = 10f;
    }

    // Update is called once per frame
    private void Update()
    {
        location = cam.WorldToScreenPoint(transform.position);
        checkInput();
    }

    

    void checkInput()
    {
        if (Input.GetMouseButtonDown(0))
        {
            jumpFunction();
        }

    }

    void jumpFunction()
    {
        velocity = getMousePos();
        playerRigidBody.linearVelocity += (velocity*jumpValue);
    }

    Vector2 getMousePos()
    {
        mousePos = Input.mousePosition;
        direction += (location - mousePos);
        if (direction.magnitude > 0)
        {
            direction.Normalize();
        }
        return direction;
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            SceneManager.LoadScene("Lose");
        }
    }

}
