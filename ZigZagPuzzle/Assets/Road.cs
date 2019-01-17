using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Road : MonoBehaviour
{
    public GameObject roadPrefab;
    public Vector3 lastRoadboxPosition;
    public float offset;


    public void StartBuildingRoads()
    {
        InvokeRepeating("CreateNewRoadBox", 1F, 0.5F);
    }
    

    public void CreateNewRoadBox()
    {
        Vector3 spawnPosition = Vector3.zero;

        float chance = Random.Range(0, 100);

        if (chance <50)
        {
            spawnPosition = new Vector3(lastRoadboxPosition.x + offset, lastRoadboxPosition.y, lastRoadboxPosition.z + offset);
        }
        else
        {
            spawnPosition = new Vector3(lastRoadboxPosition.x - offset, lastRoadboxPosition.y, lastRoadboxPosition.z + offset);
        }
        
        GameObject obj = Instantiate(roadPrefab, spawnPosition, Quaternion.Euler(0, 45, 0));
        lastRoadboxPosition = obj.transform.position;


    }
   
}
