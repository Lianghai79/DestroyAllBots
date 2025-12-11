using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public GameObject Player;
    Rigidbody2D enemyRigidBody;

    public float speed;
    
    public float seperation;
    public float xPos;
    
    public float playX;
    
    public Vector2 playerPos;
    public Vector2 enemyPos;
    public Vector2 direction;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Player = GameObject.Find("Player");
        enemyRigidBody = GetComponent<Rigidbody2D>();
        speed = 2;
    }

    // Update is called once per frame
    void Update()
    {
        seperation = distance();
        if (seperation < 10)
        {
            xPos = finding();
            enemyRigidBody.linearVelocityX = xPos*speed;
        }
    }

    float finding()
    {
        playX = Player.transform.position.x;

        playX -= transform.position.x;

        if (playX != 0)
        {
            playX = (playX / Mathf.Abs(playX));
        }
        return playX;
    }

    float distance()
    {
        playerPos = Player.transform.position;
        enemyPos = transform.position;
        direction = (playerPos - enemyPos);
        return Mathf.Abs(direction.magnitude);
    }
}
