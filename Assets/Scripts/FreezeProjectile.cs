using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

// By: Nicolas Assakura Miyazaki
public class FreezeProjectile : MonoBehaviour
{
    [SerializeField]
    private float maxTravelDist;

    private Rigidbody2D rigBod2D;
    private Vector2 startPos;

    // Note: Needs to be Awake and not Start so that this gets set up before Fire is called
    // by PlayerController in the next line
    private void Awake()
    {
        rigBod2D = GetComponent<Rigidbody2D>();
        startPos = transform.position;
    }

    private void Update()
    {
        // Checking if we have gone over the maximum travel distance
        if (Vector2.Distance(startPos, transform.position) >= maxTravelDist)
        {
            Destroy(gameObject);
        }
    }

    public void Fire(Vector2 fireVelocity)
    {
        rigBod2D.velocity = fireVelocity;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Enemy enemy = collision.gameObject.GetComponent<Enemy>();
        if (enemy)
        {
            enemy.freeze();
            Destroy(gameObject);
        }
    }
}
