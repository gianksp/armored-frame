using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mech : MonoBehaviour
{
    public GameObject torso;
    public GameObject rightMuzzle;
    public GameObject leftMuzzle;
    public GameObject projectile;
    public float movementSpeed = 2f;
    public float rotationSpeed = 100f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        HandleEvents();
        HandleTranslation();
        HandleBaseRotation();
        HandleTorsoRotation();
        HandleFiring();
    }

    void HandleTranslation()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * movementSpeed);
        } else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * Time.deltaTime * movementSpeed);
        }
    }

    void HandleBaseRotation()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            torso.transform.Rotate(Vector3.down * Time.deltaTime * rotationSpeed);
        } else if (Input.GetKey(KeyCode.E))
        {
            torso.transform.Rotate(Vector3.up * Time.deltaTime * rotationSpeed);
        }
    }

    void HandleTorsoRotation()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.down * Time.deltaTime * rotationSpeed);
        } else if (Input.GetKey(KeyCode.RightArrow))
        {
           transform.Rotate(Vector3.up * Time.deltaTime * rotationSpeed);
        }
    }

    void HandleFiring()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject leftBullet = (GameObject) Instantiate(projectile, leftMuzzle.transform.position, 
            leftMuzzle.transform.rotation);

            GameObject rightBullet = (GameObject) Instantiate(projectile, rightMuzzle.transform.position, 
            rightMuzzle.transform.rotation);
    
        // Rigidbody projectileRb = projectileGO.GetComponent<Rigidbody>();
        // projectileRb.AddForce(throwForce * Vector3.forward, ForceMode.Impulse);
        }
    }

    void HandleEvents()
    {

    }
}
