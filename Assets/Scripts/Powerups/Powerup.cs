using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// By: Nicolas Assakura Miyazaki
public abstract class Powerup : MonoBehaviour
{
    [SerializeField]
    private float duration;
    [SerializeField]
    private AudioSource audSrc;

    private void Awake()
    {
        WorldMover.addMovable(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerController collidingPlayer = collision.gameObject.GetComponent<PlayerController>();
        if (collidingPlayer)
        {
            GetComponent<SpriteRenderer>().enabled = false;
            audSrc.Play();
            Apply(collidingPlayer);
            StartCoroutine(RevertTimer(collidingPlayer));
        }
    }

    private IEnumerator RevertTimer(PlayerController player)
    {
        yield return new WaitForSeconds(duration);
        Revert(player);
        WorldMover.removeMoveable(gameObject);
        Destroy(gameObject);
    }

    public abstract void Apply(PlayerController player);

    public abstract void Revert(PlayerController player);
}
