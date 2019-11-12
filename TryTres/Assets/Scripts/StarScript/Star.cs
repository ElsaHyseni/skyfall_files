using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Star : MonoBehaviour
{
    public float movespeed = 3f;
    public float bound_y = 30f;
    public Image star_won_1;
    public Image star_won_2;
    public Image star_won_3;
    public Image star_won_4;
    public Image star_won_5;
    public static int gotFirst ;
    public Button button1;
    public Button button2;
    public Button button3;
    public Button button4;
    public Button button5;


    private void Start()
    {
        if (SceneManager.GetActiveScene().name == "Gameplay")
        {
            gotFirst = 0;
        }
        if(SceneManager.GetActiveScene().name == "GameOver")
        {
            if (gotFirst == 1)
            {
                button1.gameObject.SetActive(true);
                Debug.Log(gotFirst);
            }
            else if (gotFirst == 2)
            {
                button1.gameObject.SetActive(true);
                button2.gameObject.SetActive(true);

            }
            else if (gotFirst == 3)
            {
                button1.gameObject.SetActive(true);
                button2.gameObject.SetActive(true);
                button3.gameObject.SetActive(true);

            }
            else if (gotFirst == 4)
            {
                button1.gameObject.SetActive(true);
                button2.gameObject.SetActive(true);
                button3.gameObject.SetActive(true);
                button4.gameObject.SetActive(true);
            }
            else if(gotFirst == 5)
            {
                button1.gameObject.SetActive(true);
                button2.gameObject.SetActive(true);
                button3.gameObject.SetActive(true);
                button4.gameObject.SetActive(true);
                button5.gameObject.SetActive(true);
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "Gameplay")
        {
            Fly();
        }

    }

    void Fly()
    {
        Vector2 temp = transform.position;
        temp.y += movespeed * Time.deltaTime;
        transform.position = temp;

        if (temp.y >= bound_y)
        {
            gameObject.SetActive(false);
        }
    }


    void DeactivateStar()
    {
        SoundManager.instance.CoinSound();
        gameObject.SetActive(false);
    }

    private int OnCollisionEnter2D(Collision2D target)
    {
        if (target.gameObject.tag == "Player")
        {
            DeactivateStar();
            

            if (gameObject.name == "star")
            {
                star_won_1.gameObject.SetActive(true);
                gotFirst += 1;
                Debug.Log("Star1");
            }

            if (gameObject.name == "star2")
            {
                star_won_2.gameObject.SetActive(true);
                gotFirst += 1;
                
            }

            if (gameObject.name == "star3")
            {
                star_won_3.gameObject.SetActive(true);
                gotFirst += 1;
            }

            if (gameObject.name == "star4")
            {
                star_won_4.gameObject.SetActive(true);
                gotFirst += 1;
            }

            if (gameObject.name == "star5")
            {
                star_won_5.gameObject.SetActive(true);
                gotFirst += 1;
            }   
        }
        Debug.Log(gotFirst);
        return gotFirst;
    }


}
