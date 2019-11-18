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

    public void SubmitName(){
        print("SubmitName called: " + nameText.text);

        string[] names = nameText.text.Split(' ');

        titleText.text = welcomeText.Replace(replaceWithName, names[0]);
    }
}
