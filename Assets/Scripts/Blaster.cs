using UnityEngine;
using UnityEngine.UIElements;

public class Blaster : MonoBehaviour
{
    public GameObject Player;
    private Vector2 mousePosition;
    public Vector2 playerPos;
    public Vector2 direction;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        playerPos = Player.transform.position;
        direction += (playerPos - mousePosition);
        if (direction.magnitude > 0)
        {
            direction.Normalize();
        }

        transform.position = playerPos - (direction*2);
    }
}
