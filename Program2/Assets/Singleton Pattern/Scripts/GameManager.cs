using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool state;
    [SerializeField] static GameManager instance;
    public static GameManager Instance
    {
        get 
        { 
            if (instance == null)
            {
                instance = FindObjectOfType<GameManager>();
                if (instance == null)
                {
                    GameObject clone = new GameObject(nameof(GameManager));

                    instance = clone.AddComponent<GameManager>();
                }
                
                
            }
            return instance; 
        }
    }
    public bool State { get { return State; } }

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
     
    }
    // Start is called before the first frame update
    void Start()
    {
        state = true;
    }

    // Update is called once per frame
    public void Pause()
    {
        state = false;
    }
}
