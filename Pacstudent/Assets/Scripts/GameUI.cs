using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameUI : MonoBehaviour
{
    public GameObject gameUI;
    public GameObject beforeStart;
    public GameObject one;
    public GameObject two;
    public GameObject three;
    public GameObject go;

    float time = 0;
    
    void Start()
    {
        gameUI.transform.localScale = new Vector3(Screen.width / 1400f, Screen.height / 1050f, 1);
    }

    void Update()
    {
        time += Time.deltaTime;

        if(time > 1f && time < 2f)
        {
            three.SetActive(true);
        }
        else if(time > 2f && time < 3f)
        {
            three.SetActive(false);
            two.SetActive(true);
        }
        else if(time > 3f && time < 4f)
        {
            two.SetActive(false);
            one.SetActive(true);
        }
        else if(time > 4f && time < 5f)
        {
            one.SetActive(false);
            go.SetActive(true);
        }
        else if(time > 5f)
        {
            beforeStart.SetActive(false);
        }
        
        gameUI.transform.localScale = new Vector3(Screen.width / 1400f, Screen.height / 1050f, 1);
    }

    public void BackBtnClick()
    {
        SceneManager.LoadScene("StartScene");
    }
}
