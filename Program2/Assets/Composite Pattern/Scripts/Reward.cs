using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.UI;

public class Reward : MonoBehaviour, IRewardable
{
    [SerializeField] int random;
    [SerializeField] Data [ ] dataList;
    [SerializeField] Image image;
    

    public void Receive()
    {
        Debug.Log(gameObject.name);
    }

    private void Awake()
    {
        image = GetComponent<Image>();
    }

    void Start()
    {
        random = Random.Range(0, dataList.Length);

        gameObject.name = dataList[random].Name;
        image.sprite = dataList[random].GetSprite;
    }

}
