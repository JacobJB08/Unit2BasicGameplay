using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 40;
    private float lowerBound = -20;
    private float rightBound = 35;
    private float leftbound = -35;
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            gameManager.AddLives(-1);
            Destroy(gameObject);
        }

        if (transform.position.x > rightBound)
        {
            gameManager.AddLives(-1);
            Destroy(gameObject);
        }

        if (transform.position.x < leftbound)
        {
            gameManager.AddLives(-1);
            Destroy(gameObject);
        }
    }
}
