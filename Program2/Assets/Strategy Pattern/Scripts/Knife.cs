using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Knife : Weapon
{
    [SerializeField] Animator animator;

    public void Awake()
    {
        animator = GetComponent<Animator>();
    }
    public override void Attack()
    {
        animator.Play("Knife_Attack");
        Debug.Log("knife");
    }
}
