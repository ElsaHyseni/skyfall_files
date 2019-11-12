using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour{

    private Rigidbody2D mybody;
    public float moveSpeed = 2f;
   

    void Awake(){

        mybody = GetComponent<Rigidbody2D>(); 
    }

    void FixedUpdate()
    {
        Move();
    }
    void Move(){
        if(Input.GetAxisRaw("Horizontal") > 0f){
            mybody.velocity = new Vector2(moveSpeed, mybody.velocity.y);
        }

        if (Input.GetAxisRaw("Horizontal") < 0f){
            mybody.velocity = new Vector2(-moveSpeed, mybody.velocity.y);
        }
     
    }

    public void PlatformMove(float x){
        mybody.velocity = new Vector2(x, mybody.velocity.y);
    }
}
