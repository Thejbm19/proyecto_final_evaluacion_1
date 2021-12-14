using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollider : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider otherCollider)
    {
        if (otherCollider.gameObject.CompareTag("player") && gameObject.CompareTag("obstaculo"))
        {
            Debug.Log("Game Over");
            Time.timeScale = 0f;
        }

        if (otherCollider.gameObject.CompareTag("misil") && gameObject.CompareTag("obstaculo"))
        {
            Destroy(otherCollider.gameObject);
            Destroy(gameObject);
        }

     


    }
}
