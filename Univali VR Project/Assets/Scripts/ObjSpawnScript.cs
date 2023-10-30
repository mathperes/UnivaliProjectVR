using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjSpawnScript : MonoBehaviour
{

    public GameObject[] ObjectsPrefabs;

    private float spawnRangeXMax = 1;
    private float spawnRangeXMin = -3;
    private float spawnRangeZMax = 4;
    private float spawnRangeZMin = -2.5f;
    private float spawnRangeYMax = 0.6f;
    private float spawnRangeYMin = 2;
    
    // Start is called before the first frame update
    void Start()
    {
        SpawnObjects();
    }

    void SpawnObjects()
    {
        foreach (var obj in ObjectsPrefabs)
        {
            Vector3 spawnPos = new Vector3(Random.Range(spawnRangeXMin, spawnRangeXMax), Random.Range(spawnRangeYMin, spawnRangeYMax), Random.Range(spawnRangeZMin, spawnRangeZMax));

            Instantiate(obj, spawnPos, obj.transform.rotation);
        }
    }
}
