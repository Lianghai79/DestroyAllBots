using System.Net.Sockets;
using Unity.VisualScripting;
using UnityEngine;

public class blastScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    float timeLeft;
    
    void Start()
    {
        transform.position = transform.position + new Vector3(0,0,2);
        timeLeft = 10;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        timeLeft -= 1;
        if (timeLeft < 0)
        {
            Object.Destroy(this.gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Object.Destroy(collision.gameObject);
        }
    }
}
