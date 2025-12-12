using UnityEngine;
using UnityEngine.SceneManagement;

public class control : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float enemyLeft;
    
    void Start()
    {
        enemyLeft = 5;
    }

    // Update is called once per frame
    void Update()
    {
        if (enemyLeft == 0)
        {
            SceneManager.LoadScene("win");
        }
    }
}
