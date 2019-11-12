using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarScript : MonoBehaviour
{
    public GameObject breakablePlatformPrefab;
    public GameObject platformPrefab;
    public GameObject star1;
    private int When_to_spawn_star = 1;
    private int addition = 1;
    private Vector2 breakableTransform;

    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        breakableTransform = breakablePlatformPrefab.transform.position;
        breakableTransform.x = breakableTransform.x + 2f;

        
        When_to_spawn_star += addition;
        Debug.Log(When_to_spawn_star);
        if(When_to_spawn_star == 500)
        {
            Instantiate(star1, breakableTransform, Quaternion.identity);
        }
    }

}
