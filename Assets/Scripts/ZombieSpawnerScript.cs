using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawnerScript : MonoBehaviour
{
    //initialise values
    public GameObject Zombie; //set gameobject for zombie
    public float spawnRate = 2f; //delay in seconds (f) between zombie spawns
    public int ZombieCountMax; //max amount of zombies at a time
    float nextSpawn = 0.0f; //time until new zombie is spawned
    int AmountOfZombies = 0; //amount of zombies spawned
    
    // Update is called once per frame
    void Update()
    {
        //if zombie spawn cooldown over and amount of zombies is less than max, then do the following
        if (Time.time > nextSpawn && AmountOfZombies < ZombieCountMax)
        {
            nextSpawn = Time.time + spawnRate; //restart zombie spawn cooldown
            Instantiate(Zombie, RandomPos(), Quaternion.identity); //spawn the zombie at given location
            AmountOfZombies += 1; //increase zombie count by one each time one is spawned
        }
    }

    //generate random position for zombie to spawn
    static Vector2 RandomPos()
    {
        float randX = 0; //for random x position
        float randY = 0; //for random y position
        Vector2 whereToSpawn; //vector2 to determine spawn position

        int randSquare = Random.Range(1, 7); //choose which square to spawn zombie in
        switch (randSquare)
        {
            case 1:
                randX = Random.Range(-10.5f, -4.7f); //generate random x position for square 1
                randY = Random.Range(11.5f, 1.7f); //generate random y position for square 1
                break;
            case 2:
                randX = Random.Range(-3.4f, 13.2f); //generate random x position for square 2
                randY = Random.Range(9.4f, 7.7f); //generate random y position for square 2
                break;
            case 3:
                randX = Random.Range(1.8f, 3f); //generate random x position for square 3
                randY = Random.Range(6.3f, 5f); //generate random y position for square 3
                break;
            case 4:
                randX = Random.Range(-3.15f, 5f); //generate random x position for square 4
                randY = Random.Range(3.3f, -4f); //generate random y position for square 4
                break;
            case 5:
                randX = Random.Range(8.8f, 10.3f); //generate random x position for square 5
                randY = Random.Range(3.3f, -2.1f); //generate random y position for square 5
                break;
            case 6:
                randX = Random.Range(11.9f, 17.2f); //generate random x position for square 6
                randY = Random.Range(5.3f, -2.15f); //generate random y position for square 6
                break;
        }
        whereToSpawn = new Vector2(randX, randY); //tell zombie where to spawn
        return whereToSpawn;
    }
}


// coords
// sq1 x: -10.5 y: 11.47 to x: -4.74 y: 1.67 \/
// sq2 x: -3.41 y: 9.42 to x: 13.16 y: 7.74 \/
// sq3 x: 1.82 y: 6.32 to x: 3.1 y: 4.95 \/
// sq4 x: -3.15 y: 3.27 to x: 5 y: -4 \/
// sq5 x: 8.81 y: 3.31 to x: 10.28 y: -2.11 \/
// sq6 x: 11.89 y: 5.28 to x: 17.17 y: -2.15 \/