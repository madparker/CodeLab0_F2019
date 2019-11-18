using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneScript : MonoBehaviour
{
    //change to a new scene
    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName); //change to whatever scene is named by sceneName
    }
}
