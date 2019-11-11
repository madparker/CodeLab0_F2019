using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public GameObject prefab; //prefab that we intend to clone in our scene

    // Start is called before the first frame update
    void Start()
    {
        Spawn();//call the spawn function
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //function that adds a new sphere to your scene
    public void Spawn(){
        Instantiate(prefab); //create a new gameObject from a prefab
    }
}
