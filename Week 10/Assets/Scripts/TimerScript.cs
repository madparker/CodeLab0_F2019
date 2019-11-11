using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    public GameObject timerObject;
    public SpawnerScript spawnerScript;

    Text timerTextComp;

    int timer = 0;

    float spawnTime = 2;
    float spawnMinTime = 0.2f;

    // Start is called before the first frame update
    void Start()
    {
        timerTextComp = timerObject.GetComponent<Text>();
        timerTextComp.text = "Pancreas";
        InvokeRepeating("UpdateText", 1, 1);

        Invoke("TriggerSpawn", spawnTime);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.anyKey){
            CancelInvoke();
        }
    }

    void UpdateText(){
        timer++;
        timerTextComp.text = "Time: " + timer;
    }

    void TriggerSpawn(){
        spawnerScript.Spawn();
        spawnTime -= .3f;

        if(spawnTime < spawnMinTime){
            spawnTime = spawnMinTime;
        }

        Invoke("TriggerSpawn", spawnTime);
    }
}
