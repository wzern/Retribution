using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieDamage : MonoBehaviour
{
    public int zombieHealth = 30;
    int damage= 10;

    private void Start()
    {
        print (zombieHealth);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            print("Player Collided");
        }
    }
}
