using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBounds : MonoBehaviour
{
    

    private float xlimitMax = 400f;
    private float ylimitMax = 400f;
    private float zlimitMax = 400f;
   
    void Update()
    {
        if (transform.position.x >= xlimitMax || transform.position.y >= ylimitMax || transform.position.z >= zlimitMax || transform.position.x <= -xlimitMax || transform.position.x <= -ylimitMax || transform.position.x <= -zlimitMax) {
            Destroy(gameObject);
        }
    }
}
