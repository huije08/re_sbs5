using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chilick : MonoBehaviour
{
    [SerializeField] float speed = 1.0f;
    [SerializeField] Vector3 minScale = new Vector3(1, 1, 1);
    [SerializeField] Vector3 maxScale = new Vector3(2, 2, 2);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.State == false) return;
        float x = Mathf.PingPong(Time.time * speed, 1.0f);
        transform.localScale = minScale + (maxScale - minScale) * x;
    }
}
