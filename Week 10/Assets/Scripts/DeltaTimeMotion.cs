using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeltaTimeMotion : MonoBehaviour
{
    public float speed = 2; //a public speed variable

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currentPos = transform.position; //get the current position from the transform

        //the line below moves the current position "speed" distance in 1 second using Time.deltaTime
        currentPos.x += speed * Time.deltaTime; //use the fraction of a second between frames multiplied by the speed to move this gameObject

        transform.position = currentPos; //set the gameObjects position to the new position
    }
}
