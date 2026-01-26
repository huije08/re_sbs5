using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minotaur : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] Vector3 direction;
    [SerializeField] Transform portalTransform;
    // Start is called before the first frame update
    private void OnEnalbe()
    {

        portalTransform = GameObject.Find("Portal").transform;

        transform.LookAt(portalTransform);

        direction = (portalTransform.position - transform.position).normalized;

    }
    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime, Space.World);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Portal"))
        {
            ObjectPool.Instance.Return(gameObject);
        }
    }
}
