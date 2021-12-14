using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float HorizontalInput;
    public float VerticalInput;
    public float speed = 10f;
    public float turnSpeed = 20f;
    private float xRange = 200f;
    private float yRange = 200f;
    private float zRange = 200f;
    private Vector3 startPos = new Vector3(0, 100, 0);
    public GameObject projectilePrefab;
    private int coins;
    public GameObject coinPrefab;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = startPos;
    }

    // Update is called once per frame
    void Update()
    {
        VerticalInput = -Input.GetAxis("Vertical");
        HorizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime * HorizontalInput);
        transform.Rotate(Vector3.right * turnSpeed * Time.deltaTime * VerticalInput);

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.y > yRange)
        {
            transform.position = new Vector3(transform.position.x, yRange, transform.position.z);
        }

        if (transform.position.y < 0)
        {
            transform.position = new Vector3(transform.position.x, 0, transform.position.z);
        }

        if (transform.position.z > zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
        }

        if (transform.position.z < -zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zRange);
        }

        if (Input.GetKeyDown(KeyCode.RightControl))
        {
            Instantiate(projectilePrefab, transform.position, transform.rotation);
        }


    }
    private void OnCollisionEnter(Collision otherCollider)
    {

        if (gameObject.CompareTag("moneda"))
        {
            coins = coins +1;
            Destroy(coinPrefab);
        }
    }
}
