using UnityEngine;
using UnityEngine.Rendering;

public class Player : MonoBehaviour
{
    Vector3 mousePos;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        momentum();
    }

    void momentum()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            mousePos = new Vector3(0, 1, 0);
            transform.position += mousePos;
            Debug.Log("W is down");
        }

    }
}
