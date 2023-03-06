using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int health = 5;

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            health--; //Decrease by 1

            if (health <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
    /*
        Bee otherBee = col.gameObject.GetComponent<Bee>();
        if (otherBee != null)
        {
        }
     */
}
