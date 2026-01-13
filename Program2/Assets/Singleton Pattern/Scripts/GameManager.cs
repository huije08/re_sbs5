using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] bool state;

    // Start is called before the first frame update
    void Start()
    {
        state = true;
    }

    // Update is called once per frame
    void Pause()
    {
        state = false;
    }
}
