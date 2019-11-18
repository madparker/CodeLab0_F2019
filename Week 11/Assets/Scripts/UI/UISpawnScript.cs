using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UISpawnScript : MonoBehaviour
{
    public GameObject newSphere;

    public void SpawnSphere(){
        newSphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);

        SphereCollider sc = newSphere.GetComponent<SphereCollider>();
        Destroy(sc);

        Invoke("Add2DPhysics", 0);
    }

    public void Add2DPhysics(){
        newSphere.AddComponent<CircleCollider2D>();

        newSphere.AddComponent<Rigidbody2D>();
    }
}
