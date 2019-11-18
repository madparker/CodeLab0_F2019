using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIButtonManagerScript : MonoBehaviour
{
    public GameObject leftButton;
    public GameObject rightButton;
    public GameObject nameField;
    public GameObject submit;

    //Turns off the nameField and submit button
    //Turns on the leftButton and rightButton
    public void TurnOnLeftRightButtons(){
        leftButton.SetActive(true);
        rightButton.SetActive(true);
        nameField.SetActive(false);
        submit.SetActive(false);
    }
}
