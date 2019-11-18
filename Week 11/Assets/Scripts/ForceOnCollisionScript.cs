using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceOnCollisionScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //OnCollisionEnter2D is called when objects with 2D physics collide
    private void OnCollisionEnter2D(Collision2D collision)
    {
        print("HIT!"); //print hit
    }
}
