using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawnerScript : MonoBehaviour
{
    //initialise values
    public GameObject Zombie; //set gameobject for zombie
    public float spawnRate = 2f; //delay in seconds (f) between zombie spawns
    public int ZombieCountMax; //max amount of zombies at a time

    float randx; //for random x position
    float randy; //for random y position
    float nextSpawn = 0.0f; //time until new zombie is spawned
    int AmountOfZombies = 0; //amount of zombies spawned

    Vector2 whereToSpawn; //vector2 to determine spawn position
   
    // Update is called once per frame
    void Update()
    {
        //if zombie spawn cooldown over and amount of zombies is less than max, then do the following
        if (Time.time > nextSpawn && AmountOfZombies < ZombieCountMax)
        {
            nextSpawn = Time.time + spawnRate; //restart zombie spawn cooldown
            randx = Random.Range(-8.4f, 8.4f); //generate random x position
            randy = Random.Range(-8f, 8f); //generate random y position
            whereToSpawn = new Vector2(randx, randy); //tell zombie where to spawn
            Instantiate(Zombie, whereToSpawn, Quaternion.identity); //spawn the zombie at given location
            AmountOfZombies += 1; //increase zombie count by one each time one is spawned
        }
    }
}
