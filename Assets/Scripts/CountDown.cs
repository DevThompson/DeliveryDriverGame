using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountDown : MonoBehaviour
{
    [SerializeField] float timeLeft = 15;
    [SerializeField] int gameOverScene;
    public Text countDwnTime;
    float minutesLeft;
    float secondsLeft;
    GameObject RulesCanvas;

    void Start() 
    {
      RulesCanvas = GameObject.Find("RulesAndSelectCar");
    }

    // Update is called once per frame
    void Update()
    {
        if (timeLeft > 0 && RulesCanvas.activeSelf == false)
        {
            timeLeft -= Time.deltaTime;

            minutesLeft = TimeSpan.FromSeconds(timeLeft).Minutes;
            secondsLeft = TimeSpan.FromSeconds(timeLeft).Seconds;

            countDwnTime.text = minutesLeft.ToString() + " : " + secondsLeft.ToString();
        }      
        if (timeLeft < 0.999)
        {
          SceneManager.LoadScene(gameOverScene);
        }  
    }
}
