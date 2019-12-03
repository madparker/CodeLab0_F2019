using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSystem : MonoBehaviour
{
    public Vector2 minForce; //the min force for a new particle
    public Vector2 maxForce; //the max force for a new particle

    public int minParticles = 50;  //min num particles
    public int maxParticles = 100; //max num particles

    float minYPos = -10; //y position to destroy particles at
    bool particleSwitch = false; //flag for whether to create particles or not

    List<GameObject> particleList = new List<GameObject>(); //list holding all particles

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(minParticles > 1000){ //if we have too many particles
            minParticles = 1000; //restrict to 1000
        }
        if(maxParticles > 1000){ //if we have too many particles //if we have too many particles
            maxParticles = 1000;//restrict to 1000
        }

        if(particleSwitch){
            //check the number of particles in the list
            //against the min
            //if there are less, create particles
            while (particleList.Count < minParticles)
            {
                CreateParticle();
            }

            if(particleList.Count < maxParticles){ //we haven't reached max particles
                CreateParticle(); //create a new particle
            }
        }

        List<GameObject> retiredParticles = new List<GameObject>(); //list to hold dead particles

        foreach(GameObject particle in particleList){ //go through all the particles
            if(particle.transform.position.y < minYPos){ //if a particle falls below minYpos
                retiredParticles.Add(particle); //add this particle to the retiredParticles list
            }
        }

        foreach(GameObject particle in retiredParticles){ //for each particle in retiredParticles
            particleList.Remove(particle); //remove this particle from particleList
            Destroy(particle); //Destroy that particle
        }
    }

    void CreateParticle(){
        //create a new particle from a prefab in the Resouces folder
        GameObject newPart = Instantiate<GameObject>(Resources.Load<GameObject>("Prefabs/ParticleSprite"));

        newPart.transform.position = transform.position; //move the new particle to this position
        Rigidbody2D rb = newPart.GetComponent<Rigidbody2D>(); //get the Rigidbody2D
        rb.AddForce( //give it a random force between minForce and maxForce
            new Vector2(
                Random.Range(minForce.x, maxForce.x),
                Random.Range(minForce.y, maxForce.y)));

        particleList.Add(newPart); //add the particle to the particleList 
    }

    //toggle particle system
    public void ToggleParticleSystem(){ 
        particleSwitch = !particleSwitch; //set particleSwitch to the opposite of what it current is
    }
}
