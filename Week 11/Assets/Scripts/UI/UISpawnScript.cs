using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UISpawnScript : MonoBehaviour
{
    public GameObject newSphere;

    public void SpawnSphere(){
        newSphere = GameObject.CreatePrimitive(PrimitiveType.Sphere); //create Unity Primitive Sphere

        SphereCollider sc = newSphere.GetComponent<SphereCollider>(); //get the SphereCollider from it
        Destroy(sc); //destroy the SphereCollider

        Invoke("Add2DPhysics", 0); //invoke Add2DPhysics next frame
    }

    public void Add2DPhysics(){
        newSphere.AddComponent<CircleCollider2D>(); //add a CircleCollider2D to newSphere

        newSphere.AddComponent<Rigidbody2D>(); //add a Rigidbody2D to newSphere
    }
}
