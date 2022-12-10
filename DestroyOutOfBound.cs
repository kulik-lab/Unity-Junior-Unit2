using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBound : MonoBehaviour
{
    public float topBound = 50.0f;
    public float lowerBound = -10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
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
            Destroy(gameObject); // destroy animal offscreen
        }
        
    }
}
