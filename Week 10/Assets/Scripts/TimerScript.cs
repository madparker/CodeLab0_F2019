using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    public GameObject timerObject; //UI gameObject 
    public SpawnerScript spawnerScript; //var for access to the Spawner Script

    Text timerTextComp; //var for the UI Text Component

    int timer = 0; //create a timer and set it to 0

    float spawnTime = 2; //create an init spawnTimer for how long between spawne we wait
    float spawnMinTime = 0.2f; //minimum for spawnTime

    // Start is called before the first frame update
    void Start()
    {
        timerTextComp = timerObject.GetComponent<Text>(); //get the Text component from TimerObject
        timerTextComp.text = "Pancreas"; //set the init text value
        InvokeRepeating("UpdateText", 1, 1); //use InvokeRepeating to call UpdateText after 1 second and then repeat every 1 second

        Invoke("TriggerSpawn", spawnTime); // use Invoke to call TriggerSpawn after "spawnTime" seconds
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.anyKey){ //if a key is press
            CancelInvoke(); //cancel all invokes
        }
    }

    //Update the timerTextComp text
    void UpdateText(){ 
        timer++; //increase the timer
        timerTextComp.text = "Time: " + timer; //display the timer in timerTextComp
    }

    //function to trigger the spawning of a new sphere
    void TriggerSpawn(){
        spawnerScript.Spawn(); //use spawnerScript to create a new sphere
        spawnTime -= .3f; //decrease spawnTime by .3f

        if (spawnTime < spawnMinTime){ //if the spawnTime is less than spawnMinTime
            spawnTime = spawnMinTime; //set the spawnTime to spawnMinTime
        }

        Invoke("TriggerSpawn", spawnTime); //use invoke to call TriggerSpawn again in spawnTime seconds
    }
}
