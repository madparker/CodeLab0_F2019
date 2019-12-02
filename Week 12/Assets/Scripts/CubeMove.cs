using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : MonoBehaviour
{
    public enum Movement_Type //enum for different types of math based movement
    {
        Straight, Sin, Circle, Random, Noise
    }

    public Movement_Type movement; //movement var of the enum type

    public float timer = 0; //timer to track how long the game has been running
    public float freq = 1;  //waveLength, how often the wave reaches it's peak
    public float amp = 5;   //amplitude, how high/low the peaks and valleys are

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime; //add time to timer every frame

        //switch statement:
        //like a set of if statements, but can only be used to check
        //if a single variable is of a certain type
        switch (movement) //for the movment var
        {
            case Movement_Type.Straight: //if movement is set to Straight
                transform.Translate(new Vector3(Time.deltaTime, 0, 0)); //move straight
                break;  //leave the current block of th code, the switch statement
            case Movement_Type.Sin: //if movement is set to Sin
                transform.position = new Vector3(
                        transform.position.x + Time.deltaTime,          //x
                        Mathf.Sin(transform.position.x * freq) * amp,   //y      
                        0);                                             //z
                break;  //leave the current block of th code, the switch statement
            case Movement_Type.Circle: //if movement is set to Circle
                transform.position = new Vector3( //move in a circle
                    Mathf.Cos(timer * freq) * amp,  //use cos for the x-axis
                    Mathf.Sin(timer * freq) * amp,  //use sin for the y-axis
                    0);
                break;  //leave the current block of th code, the switch statement
            case Movement_Type.Random: //if movement is set to Random
                transform.position = new Vector3( //move randomly up and down
                    transform.position.x + Time.deltaTime,
                    transform.position.y + Random.Range(-0.1f, 0.1f),
                    0
                );
                break;  //leave the current block of th code, the switch statement
            case Movement_Type.Noise: //if movement is set to Noise
                transform.position = new Vector3( //use Perlin Noise to move up and down
                    transform.position.x + Time.deltaTime,
                    (Mathf.PerlinNoise(transform.position.x, 0) * 2 - 1) * amp,
                    0
                );
                break;  //leave the current block of th code, the switch statement
            default: //Default
                Debug.Log("Something is wrong with Movement Type");
                break;  //leave the current block of th code, the switch statement
        }

        print("Sin Wave: " + Mathf.Sin(transform.position.x)); //print the values of Sin Wave

        if(transform.position.x > 10.5f){ //if you reach one end of the screen
            transform.position = new Vector3(-10.5f, transform.position.y, 0); //wrap around
        }
    }
}
