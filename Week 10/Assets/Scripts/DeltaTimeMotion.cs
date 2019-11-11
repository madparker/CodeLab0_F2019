using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeltaTimeMotion : MonoBehaviour
{
    public float speed = 2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currentPos = transform.position;

        currentPos.x += speed * Time.deltaTime;

        transform.position = currentPos;
    }
}
