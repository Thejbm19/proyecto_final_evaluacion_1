using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollider : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision otherCollider)
    {
        if (otherCollider.gameObject.CompareTag("player") && gameObject.CompareTag("obstaculo"))
        {
            Destroy(gameObject);
            Debug.Log("Game Over");
        }

        if (otherCollider.gameObject.CompareTag("misil") && gameObject.CompareTag("obstaculo"))
        {
            Destroy(gameObject);
        }

     


    }
}
