using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAnimalForward : MonoBehaviour
{
    private float animalSpeed = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * animalSpeed * Time.deltaTime);
    }
}
