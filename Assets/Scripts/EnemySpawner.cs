using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> Enemies;  //A list of pillar object templates
    [SerializeField]
    private float spawnMinTime; //The minimum amount of time to wait before spawning a pillar
    [SerializeField]
    private float spawnMaxTime; //The maximum amount of time to wait before spawning a pillar

    private float nextSpawnTime = 0.0f; //The next time to spawn a pillar
    
    private float timerr = 0.0f;

    public Rigidbody2D enemy;
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Instantiate(enemy, transform);
        nextSpawnTime = Random.Range(spawnMinTime, spawnMaxTime);
        //Initalize when you will spawn the first pillar here.
       
    }

    // Update is called once per frame
    void Update()
    {
        timerr += Time.deltaTime;

        if (timerr > nextSpawnTime) 
        {
            timerr -= timerr;
            GameObject.Instantiate(enemy, transform);
            nextSpawnTime = Random.Range(spawnMinTime, spawnMaxTime);
        }





        //Here we will want to check if it's time to spawn another pillar. 

        //To spawn a pillar:
        //Randomly select a pillar template from the list
        //Use Instantiate to create an instance of that template in the game world.
        //Select the next time to spawn a pillar


    }
}
