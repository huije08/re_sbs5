using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Granade : Weapon
{
    public override void Attack()
    {
        Debug.Log("Granade");
    }
}
