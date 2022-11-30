using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pow_ReduceShootCooldown : Powerup
{
    [SerializeField]
    [Tooltip("0.75 = cooldown becomes 3/4 of what was; ie. a 4 sec cooldown becomes 3 sec")]
    private float cooldownReduction;

    public override void Apply(PlayerController player)
    {
        player.projectileCooldown *= cooldownReduction;
    }

    public override void Revert(PlayerController player)
    {
        player.projectileCooldown /= cooldownReduction;
    }
}
