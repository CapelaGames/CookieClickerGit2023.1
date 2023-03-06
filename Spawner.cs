using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject spawnPrefab;
    public Transform  parentObject;

    void Start()
    {
        // -- while
        //do while
        //for
        //foreach

        // == is equal?
        // != is not equal to
        // < is less than
        // <= is less than or equal to
        // > is greater than
        // >= is greater than or equal to
        
        int count = 0;
        while(count < 10 )
        {
            count += 1;
            SpawnObject();

        }
    }
    
    public void SpawnObject()
    {
        //Instantiate creates a gameobject
        Instantiate(spawnPrefab, parentObject.position, Quaternion.identity, parentObject);
    }
}
