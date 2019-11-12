using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine.SceneManagement;

public class score : MonoBehaviour
{
    public float scoretime = 2;
    private float currentime;
    public Text scoreText;
    public static float Score;
    private float addition = 0.06f;
    public GameObject star;
    private float bonusPoints = 20f;
    public Text yourscoreis;
    private bool isPressed1;
  

    private void Start()
    {
     
        Scene currentscene = SceneManager.GetActiveScene();
        string scenename = currentscene.name;


        if (scenename == "GameOver")
        {
            yourscoreis.text = "Your Score is: " + Score.ToString("0");
        }
        else
        {
            Score = 0;
        }

    }

    // Update is called once per frame
    public float Update()
    {
        
        currentime += Time.deltaTime;
        if (currentime >= scoretime && SceneManager.GetActiveScene().name == "Gameplay") {
            scoreText.text = "Score: " + (Score + 1).ToString("0");
            Score += addition;

            // Debug.Log(Score);
        }
       return Score;
       
    }

    public void onclick(Button buttonpresseed)
    {
        if (buttonpresseed.name == "button1")
        {
            Score += bonusPoints;
            yourscoreis.text = "Your Score is: " + Score.ToString("0");
            SoundManager.instance.CoinSound();
            buttonpresseed.gameObject.SetActive(false);
           
        }
        if (buttonpresseed.name == "button2")
        {
            Score += (bonusPoints + 10f);
            yourscoreis.text = "Your Score is: " + Score.ToString("0");
            SoundManager.instance.CoinSound();
            buttonpresseed.gameObject.SetActive(false);
        }
        if (buttonpresseed.name == "button3")
        {
            Score += (bonusPoints + 20f);
            yourscoreis.text = "Your Score is: " + Score.ToString("0");
            SoundManager.instance.CoinSound();
            buttonpresseed.gameObject.SetActive(false);
        }
        if (buttonpresseed.name == "button4")
        {
            Score += (bonusPoints + 30f);
            yourscoreis.text = "Your Score is: " + Score.ToString("0");
            SoundManager.instance.CoinSound();
            buttonpresseed.gameObject.SetActive(false);
        }
        if (buttonpresseed.name == "button5")
        {
            Score += (bonusPoints + 40f);
            yourscoreis.text = "Your Score is: " + Score.ToString("0");
            SoundManager.instance.CoinSound();
            buttonpresseed.gameObject.SetActive(false);
        }
    }
  
}
