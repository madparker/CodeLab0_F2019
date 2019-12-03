using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject item1;
    public GameObject item2;
    public GameObject item3;

    public Dictionary<string, string> webster; //make a dictionary of string to strings

    public Dictionary<GameObject, string> objectWeaponName; //make a dictionary of GameObjects to strings

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject); //don't destroy this object if you load a new scene

        webster = new Dictionary<string, string>(); //init webster

        //add words and definitions to webster
        webster.Add("Bird", "The Word!"); 
        webster.Add("Dog", "An animal that runs.");

        //print a word and it's definition
        print("Dog - " + webster["Dog"]);

        objectWeaponName = new Dictionary<GameObject, string>(); //init webster

        objectWeaponName.Add(item1, "Sword"); //map item1 gameObjec to "Sword"
        objectWeaponName.Add(item2, "Bow");   //map item2 gameObjec to "Bow"
        objectWeaponName.Add(item3, "Staff"); //map item3 gameObjec to "Staff"
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
