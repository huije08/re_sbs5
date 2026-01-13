using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class Fuzzbit : MonoBehaviour
{
    //[SerializeField] Vector3 axis;
    [SerializeField] float angle = 45f;
    [SerializeField] float speed = 1.0f;

    //Quaternion quaternion;

    // Start is called before the first frame update
    void Start()
    {
        //quaternion = transform.localRotation;
    }

    // Update is called once per frame
    void Update()
    {
        // float y = Mathf.PingPong(Time.time * speed, 1f);
        // float value = (y * 2f - 1f) * angle;
        // transform.localRotation = quaternion * Quaternion.AngleAxis(value, axis);
    }
}
