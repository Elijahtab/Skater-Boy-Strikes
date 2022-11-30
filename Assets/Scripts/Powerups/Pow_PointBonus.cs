using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pow_PointBonus : Powerup
{
    [SerializeField]
    private int scoreValue;

    public override void Apply(PlayerController player)
    {
        player.AddScore(scoreValue);
    }

    public override void Revert(PlayerController player)
    {
        return;
    }
}
