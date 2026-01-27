using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RewardManager : MonoBehaviour
{
    [SerializeField] int createCount;
    [SerializeField] Bundle bundle;

    [SerializeField] Reward reward;
    [SerializeField] GameObject panel;
    [SerializeField] Transform patentTransform; 
    private void Awake()
    {
        createCount = Random.Range(1, 5);
    }
    void Start()
    {
        Create();
    }

    // Update is called once per frame
    void Create()
    {
        for (int i = 0; i < createCount; i++)
        {
            bundle.Add(Instantiate(reward));
        }
    }

    public void Accept()
    {
        bundle.Receive();

        panel.SetActive(false);
    }
}
