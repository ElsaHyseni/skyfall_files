using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Platform : MonoBehaviour{

    public float move_speed = 2.5f;
    public float bound_Y = 30f;

    public bool moving_platform_right, moving_platform_left, is_Breakable, is_Spike, is_Platform;
    public Animator anim;
    private float playerScore;
 

    private void Awake()
    {
        if (is_Breakable) {
            anim = GetComponent<Animator>();
        }

     
    }
    // Update is called once per frame
    void Update()
    {
        Move();
     
        
    }

    void Move(){
        Vector2 temp = transform.position;
        temp.y += move_speed * Time.deltaTime;
        transform.position = temp;

        playerScore = score.Score;

        if(playerScore > 50f && playerScore < 200f)
        {
            move_speed += 0.0096f;

            //Debug.Log(move_speed);
        }

        if(playerScore >400f && playerScore < 800f)
        {
            move_speed += 0.0099f;

          //  Debug.Log(move_speed);
        }

        if(temp.y >= bound_Y){
            gameObject.SetActive(false);    
        }
    }

    void BreakableDeactivate(){
        Invoke("DeactivateGameObject", 1f);
    }

    void DeactivateGameObject(){
        SoundManager.instance.IceBreakSound();
        gameObject.SetActive(false);
    }

   

    private void OnTriggerEnter2D(Collider2D target)
    {
        if(target.tag == "Player")
        {
            if (is_Spike){
                target.transform.position = new Vector2(100f, 100f);
             
                
                SceneManager.LoadScene("GameOver");

            }
        }
    }

    private void OnCollisionEnter2D(Collision2D target)
    {
        if(target.gameObject.tag == "Player")
        {
            if (is_Breakable)
            {
                SoundManager.instance.LandSound();
                anim.Play("break");
            }
            if (is_Platform)
            {
                SoundManager.instance.LandSound();
            }
        }
    }

    private void OnCollisionStay2D(Collision2D target)
    {
        if(target.gameObject.tag == "Player")
        {
            if (moving_platform_left)
            {
                target.gameObject.GetComponent<PlayerMovement>().PlatformMove(-3f);
            
            }

            if (moving_platform_right)
            {
                target.gameObject.GetComponent<PlayerMovement>().PlatformMove(3f);
              
            }
        }
    }
}
