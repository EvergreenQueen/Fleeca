using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{   
    [Header("Objects")]
    [SerializeField] GameObject start;
    [SerializeField] GameObject goal;
    [SerializeField] GameObject obstacle;

    [SerializeField] GameObject[] obstacles;


    [Header("Stats")]
    [SerializeField] float minPathWidth = 5f;
    [SerializeField] float obstacleDensity = 0.50f;
    [SerializeField] float obstacleMult = 20f;
    [SerializeField] float maxSizeMult = 5f;
    [SerializeField] float absX = 9.8f;
    [SerializeField] float absY = 5.5;
    


    void Awake()
    {
        SetObstacles();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetObstacles(){
        for(int i = Mathf.CeilToInt(obstacleDensity*obstacleMult); i <= 0; i--)
        {
            foreach(Gameobject ob in obstacles){
                
            }
        }

    }


}
