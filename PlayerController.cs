using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    public int dbg1 =0;
    public float horizontalInput;
    private float speed = 15.0f;
    private float xRange = 19.0f;

    //Give the controller the access to the prefab;
    public GameObject projectilePrefab;

    //add vertical axis
    public float zMin = -6.0f;
    public float zMax =  16.0f;
    public float verticalInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // limit movement, horizontal
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        // limit movement, vertical axis

        if(transform.position.z < zMin)
        {
            transform.position = new Vector3(transform.position.x,
            transform.position.y, zMin);
            dbg1 -=1;

        }
        if(transform.position.z > zMax)
        {
            transform.position = new Vector3(transform.position.x,
            transform.position.y, zMax);
            dbg1 +=1;

        }
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);
    
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * verticalInput * speed * Time.deltaTime);
   
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab,new Vector3(transform.position.x, 1.0f, transform.position.z  + 2.0f), projectilePrefab.transform.rotation);
        }
    
    }
}
