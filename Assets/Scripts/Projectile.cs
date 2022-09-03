using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float projectileSpeed = 8f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 3f);
    }

    public void FixedUpdate()
    {
        // Speed will be 0 before StartMovingTowards is called so this will do nothing
        transform.Translate(transform.right * projectileSpeed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision other) {
        Destroy(gameObject);
    }
}
