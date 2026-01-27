using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Idle : IStateable
{
    public void Enter(Chaeacter chaeacter)
    {
        Debug.Log("Idle Enter");
    }

    public void Exit(Chaeacter chaeacter)
    {
        Debug.Log("Idle Exit");
    }

    public void Update(Chaeacter chaeacter)
    {
        Debug.Log("Idle Update");
    }
}
