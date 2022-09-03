using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mech : MonoBehaviour
{
    private Rigidbody _rigidBody;
    public GameObject torso;
    public float speed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        _rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
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
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        } else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * Time.deltaTime * speed);
        }
    }

    void HandleBaseRotation()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            torso.transform.Rotate(Vector3.down);
        } else if (Input.GetKey(KeyCode.E))
        {
            torso.transform.Rotate(Vector3.up);
        }
    }

    void HandleTorsoRotation()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.down);
        } else if (Input.GetKey(KeyCode.RightArrow))
        {
           transform.Rotate(Vector3.up);
        }
    }

    void HandleFiring()
    {

    }

    void HandleEvents()
    {

    }
}
