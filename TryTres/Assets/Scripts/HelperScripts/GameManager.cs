﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;
    public bool isCalled = false;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }
    public void RestartGame(){
        Invoke("RestartAfterTime", 1f);
        isCalled = true;
    }

    void RestartAfterTime(){
        UnityEngine.SceneManagement.SceneManager.LoadScene("Gameplay");
    }
}
