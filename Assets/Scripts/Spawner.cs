using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Spawner : MonoBehaviour
{
    public GameObject spawnPrefab;
    public Transform  parentObject;

    public int spawnCount = 0;
    public int spawnMultiplier = 1;

    public TMP_Text spawnCountText;

    void Start()
    {
       //IncreaseSpawnMultiplier(1);
    }

    public void IncreaseSpawnMultiplier(int increaseBy)
    {
        spawnMultiplier += increaseBy;
    }
    
    public void SpawnMultipleObjects()
    {
        int count = 0;
        while(count < spawnMultiplier )
        {
            count += 1;
            SpawnObject();
        }
    }
    
    public void SpawnObject()
    {
        //Instantiate creates a gameobject
        Instantiate(spawnPrefab, parentObject.position, Quaternion.identity, parentObject);
        spawnCount++; // spawnCount += 1; This line of code increases a number by 1
                      // spawnCount = spawnCount + 1;

        if (spawnCountText != null) //If spawnCountText is not empty
        {
            spawnCountText.text = spawnCount.ToString();
        }
    }


}
