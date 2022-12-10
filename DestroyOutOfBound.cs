using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBound : MonoBehaviour
{
    public float topBound = 40.0f;
    public float lowerBound = -10.0f;

    private float sideBound = 34;

    private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > topBound)
        {
            
            Destroy(gameObject); // destroy projectile offscreen
        }
        else if(transform.position.z < lowerBound)
        {
            gameManager.AddLives(-1);
            Destroy(gameObject); // destroy animal offscreen
        }
        else if(transform.position.x > sideBound)
        {
            gameManager.AddLives(-1);
            Destroy(gameObject);
        }
        else if(transform.position.x < -sideBound)
        {
            gameManager.AddLives(-1);
            Destroy(gameObject);
        }
    }
}
