using UnityEngine;

public class blastScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    float timeLeft;
    
    void Start()
    {
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
}
