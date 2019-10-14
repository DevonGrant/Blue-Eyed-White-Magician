using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeScene : MonoBehaviour
{
    //10/13/19
    //Script is to change between the different scenes of our game
    bool start;
    bool sample;
    bool gameover;
    public GameObject wizard;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //call the method to update the scene
        checkScene();
    }

    //method to check the scenes
    void checkScene()
    {
        if(SceneManager.GetActiveScene().name == "Start Menu")
        {
            //change scene based on user input
            if (Input.GetKeyDown(KeyCode.P) ||
                Input.GetKeyDown(KeyCode.Space) ||
                Input.GetKeyDown(KeyCode.Return) ||
                Input.GetMouseButtonDown(0))
            {
                SceneManager.LoadScene("SampleScene");
            }
        }
        else if(SceneManager.GetActiveScene().name == "SampleScene")
        {        
            if (wizard.activeInHierarchy == false)
            {
                //change the scene based on user input
                if (Input.GetKeyDown(KeyCode.R) ||
                     Input.GetMouseButtonDown(0))
                {
                    SceneManager.LoadScene("Game Over");
                }
            }
        }
        else if(SceneManager.GetActiveScene().name == "Game Over")
        {
            //change the scene based on user imput
            if(Input.GetKeyDown(KeyCode.P) ||
                Input.GetKeyDown(KeyCode.Space) ||
                Input.GetKeyDown(KeyCode.Return) ||
                Input.GetMouseButtonDown(0))
            {
                SceneManager.LoadScene("Start Menu");
            }
        }
    }
}
