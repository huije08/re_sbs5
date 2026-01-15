using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Berrion : MonoBehaviour
{
    [SerializeField] float speed = 1.0f;
    [SerializeField] float distance = 2.0f;
    [SerializeField] Vector3 direction = Vector3.right;

    [SerializeField] Vector3 initializePosition;
    
    // Start is called before the first frame update
    void Start()
    {
        initializePosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.State == false) return;
        float z = Mathf.PingPong(Time.time * speed, 1f);

        transform.localPosition=initializePosition+direction.normalized*z;
        transform.rotation = Quaternion.Euler(0, z, 0);
    }
}
