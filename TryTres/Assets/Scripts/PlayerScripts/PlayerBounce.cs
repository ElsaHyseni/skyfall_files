using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerBounce : MonoBehaviour
{
    public float min_X = -6.3f, max_X = 6.3f, min_Y = -6f;
    private bool out_of_bounds;

    // Update is called once per frame
    void Update()
    {
        CheckBounds();
    }

    void CheckBounds()
    {
        Vector2 temp = transform.position;

        if(temp.x > max_X){
            temp.x = max_X;
        }
        if(temp.x < min_X){
            temp.x = min_X;
        }

        transform.position = temp;

        if(temp.y <= min_Y){
            if (!out_of_bounds){
                out_of_bounds = true;
               
                SceneManager.LoadScene("GameOver");

            }
        }
    }

    private void OnTriggerEnter2D(Collider2D target)
    {
        if(target.tag == "TopSpikes"){
            transform.position = new Vector2(100f, 100f);
            
            SceneManager.LoadScene("GameOver");
        }
    }

    
}
