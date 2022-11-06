using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovingPacman : MonoBehaviour
{
    public GameObject mainUI;
    public GameObject pacman;
    bool movingDirection = true;

    void Start()
    {
        mainUI.transform.localScale = new Vector3(Screen.width / 1400f, Screen.height / 1050f, 1);
    }

    void Update()
    {  
        mainUI.transform.localScale = new Vector3(Screen.width / 1400f, Screen.height / 1050f, 1);

        if(pacman.transform.position.x <= 400f)
        {
            movingDirection = true;
        }
        else if(pacman.transform.position.x >= 1000f)
        {
            movingDirection = false;
        }

        if(movingDirection)
        {
            pacman.transform.position = new Vector3(pacman.transform.position.x + 50f * Time.deltaTime, pacman.transform.position.y, pacman.transform.position.z);
        }
        else{
            pacman.transform.position = new Vector3(pacman.transform.position.x - 50f * Time.deltaTime, pacman.transform.position.y, pacman.transform.position.z);
        }        
    }


    public void Level1BtnClick()
    {
        SceneManager.LoadScene("Game");
    }
}
