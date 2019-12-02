using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectClicker : MonoBehaviour
{
    ParticleSystem particleSystem;

    // Start is called before the first frame update
    void Start()
    {
        particleSystem = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) //if I click
        {
            RaycastHit hit; //stores info about what the ray hit

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); //create a ray from the camera to the mouse position
            if (Physics.Raycast(ray, out hit)) //raycast
            {
                if (hit.collider.gameObject == gameObject)  //the mouse is over this object
                {
                    particleSystem.ToggleParticleSystem();
                    print("Clicked on: " + gameObject.name);//then print to console
                }
            }
        }
    }
}
