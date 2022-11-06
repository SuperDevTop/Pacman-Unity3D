using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameEngine : MonoBehaviour
{
    public Text scoreText;
    int num = 0;
    
    void OnTriggerEnter(Collider col)
    {
        if(col.tag == "pallet")
        {
            col.gameObject.SetActive(false);
            num++;
            scoreText.text = num.ToString();
        }
    }
}
