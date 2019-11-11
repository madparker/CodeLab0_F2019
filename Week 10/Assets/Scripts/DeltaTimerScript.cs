using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//additional library we must include to let Unity know
//what Text and other UI script
using UnityEngine.UI;

public class DeltaTimerScript : MonoBehaviour
{
    public Text deltaTimerText; //variable for the Text component from another script
    public float deltaTimer = 0; //var to tract the amount of time that has elapsed

    // Start is called before the first frame update
    void Start()
    {
        deltaTimerText.text = "Hello!"; //set the text in deltaTimerText
    }

    // Update is called once per frame
    void Update()
    {
        deltaTimer += Time.deltaTime; //add the fractions of a second since last frame to deltaTimer
        deltaTimerText.text = "Time: " + deltaTimer; //display the current deltaTimer in deltaTimerText

        //if the deltaTimer is greater than 9 and less than 10
        //(if between 9 seconds and 10 seconds have gone by)
        if (deltaTimer > 9 && deltaTimer < 10){
            print("TIMES RUNNING OUT!!!"); //print to console
        }

        //if over 10 seconds have gone by
        if(deltaTimer > 10){
            print("GAME OVER"); //print to console
        }

        //print("DeltaTime: " + Time.deltaTime);
    }
}
