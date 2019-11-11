using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeltaTimerScript : MonoBehaviour
{
    public Text deltaTimerText;
    public float deltaTimer = 0;

    // Start is called before the first frame update
    void Start()
    {
        deltaTimerText.text = "Hello!";
    }

    // Update is called once per frame
    void Update()
    {
        deltaTimer += Time.deltaTime;
        deltaTimerText.text = "Time: " + deltaTimer;

        if(deltaTimer > 9 && deltaTimer < 10){
            print("TIMES RUNNING OUT!!!");
        }

        if(deltaTimer > 10){
            print("GAME OVER");
        }

        //print("DeltaTime: " + Time.deltaTime);
    }
}
