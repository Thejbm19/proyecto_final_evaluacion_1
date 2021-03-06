using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public float randomRangeX;
    public float randomRangeY;
    public float randomRangeZ;
    public float MaxRangex = 200f;
    public float MaxRangey = 200f;
    public float MaxRangez = 200f;
    public GameObject prefabObs;


     void Start()
     {
        InvokeRepeating("SpawnObstacle",2f,5f);

     }

    // Update is called once per frame
    void Update()
    { 
        
    }

    public Vector3 RandomPosition()
    {
        randomRangeX = Random.Range(-MaxRangex, MaxRangex);
        randomRangeY = Random.Range(0, MaxRangey);
        randomRangeZ = Random.Range(-MaxRangez, MaxRangez);
        return new Vector3(randomRangeX, randomRangeY, randomRangeZ);
    }

    public void SpawnObstacle()
    {
        Instantiate(prefabObs,RandomPosition(), prefabObs.transform.rotation);
    }
 
}
