using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner1 : MonoBehaviour
{
    public GameObject platformPrefab;
    public GameObject spikePlatformPrefab;
    public GameObject[] movingPlatforms;
    public GameObject breakablePlatformPrefab;


    public float platform_Spawn_Timer = 1.8f;
    private float current_platform_spawn_timer;

    private int platform_Spawn_Count;
    public float min_X = -4.5f, max_X = 4.5f;
    

    // Start is called before the first frame update
    void Start()
    {
        current_platform_spawn_timer = platform_Spawn_Timer;
    }

    // Update is called once per frame
    void Update()
    {
        SpawnPlatforms();
    }

    void SpawnPlatforms(){
        current_platform_spawn_timer += Time.deltaTime;

        if(current_platform_spawn_timer >= platform_Spawn_Timer) {

            platform_Spawn_Count++;

            Vector3 temp = transform.position;
            temp.x = Random.Range(min_X, max_X);

         

            GameObject newplatform = null;
            
            if(platform_Spawn_Count < 2)
            {
                newplatform = Instantiate(platformPrefab, temp, Quaternion.identity);

            }else if(platform_Spawn_Count == 2)
            {
                if(Random.Range(0,2) > 0){
                    newplatform = Instantiate(platformPrefab, temp, Quaternion.identity);
                }
                else {
                    newplatform = Instantiate(
                        movingPlatforms[Random.Range(0, movingPlatforms.Length)],
                        temp, Quaternion.identity
                        );
                }
            }
            else if (platform_Spawn_Count == 3)
            {
                if (Random.Range(0, 2) > 0)
                {
                    newplatform = Instantiate(platformPrefab, temp, Quaternion.identity);
                }
                else
                {
                    newplatform = Instantiate(breakablePlatformPrefab,
                        temp, Quaternion.identity);
                }
            }
            else if (platform_Spawn_Count == 4){

                if (Random.Range(0, 2) > 0)
                {
                    newplatform = Instantiate(platformPrefab, temp, Quaternion.identity);

                  
                }
                else
                {
                    newplatform = Instantiate(spikePlatformPrefab,
                        temp, Quaternion.identity);
                }

                platform_Spawn_Count = 0;
            }
    
                

            newplatform.transform.parent = transform;
            current_platform_spawn_timer = 0f;

        }

    }
}
