using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCoin : MonoBehaviour
{
    public float randomRangeX;
    public float randomRangeY;
    public float randomRangeZ;
    public float MaxRangex = 200f;
    public float MaxRangey = 200f;
    public float MaxRangez = 200f;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = RandomPosition();
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
}
