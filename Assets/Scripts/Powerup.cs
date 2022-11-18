using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GenericPowerUp : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerController collidingPlayer = collision.gameObject.GetComponent<PlayerController>();
        if (collidingPlayer)
        {
            Apply(collidingPlayer);
        }
    }

    public abstract void Apply(PlayerController player);
}
