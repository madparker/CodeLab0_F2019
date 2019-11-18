using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text.RegularExpressions;

public class UISubmitName : MonoBehaviour
{
    public Text nameText;
    public Text titleText;

    public string welcomeText;
    public string replaceWithName;

    //Gets the name submitted by the player and updates the text to welcome them
    public void SubmitName(){
        print("SubmitName called: " + nameText.text); //print out the submit name

        string[] names = nameText.text.Split(' '); //split the name to just get the first name

        titleText.text = welcomeText.Replace(replaceWithName, names[0]); //replace replaceWithName with the first name the player submitted in welcome text
    }
}
