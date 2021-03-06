using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControler : MonoBehaviour
{
    Scene currentScene;
    // Start is called before the first frame update
    void Start()
    {
        currentScene = SceneManager.GetActiveScene();
        Debug.Log("Our scene name is " + currentScene.name);
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.V))
        {
            if(currentScene.name == "PoleScene")
            {
                SceneManager.LoadScene("FirstLevel");
            }
            else
            {
                SceneManager.LoadScene("PoleScene");
            }
        }
    }
}
