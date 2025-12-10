using System;
using UnityEngine;
using UnityEngine.UIElements;

public class Blaster : MonoBehaviour
{
    public GameObject laserPrefab;
    public GameObject Player;
    public Vector2 mousePosition;
    private Vector2 mouseFind;
    public Vector2 playerPos;
    public float rotDir;
    
    public Vector2 direction;
    public Vector2 gunLocation;
    
    private float tanAngle;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        mousePosition = mousePos();
        playerPos = Player.transform.position;
        gunLocation = position();
        rotDir = angle();
        
        transform.position = playerPos - (gunLocation);
        Rotate(rotDir);

        if (Input.GetMouseButtonDown(0))
        {
            spawnLaser();
        }
    }

    Vector2 position()
    {
        direction += (playerPos - mousePosition);
        if (direction.magnitude > 0)
        {
            direction.Normalize();
        }
        return direction;
    }

    Vector2 mousePos()
    {
        mouseFind = Input.mousePosition;
        mouseFind = Camera.main.ScreenToWorldPoint(mouseFind);
        return mouseFind;
    }

    float angle()
    {
        tanAngle = Mathf.Atan2(gunLocation.y, gunLocation.x) * Mathf.Rad2Deg-90;
        
        return tanAngle;
    }

    public void spawnLaser()
    {
        Vector2 disTot = transform.position;
        GameObject Laser = (GameObject)Instantiate(laserPrefab, disTot-(gunLocation*3), transform.rotation);
    }
    
    void Rotate(float rotating)
    {
        Quaternion angleAxis = Quaternion.AngleAxis(rotating, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, angleAxis, Time.deltaTime * 50);
    }
}
