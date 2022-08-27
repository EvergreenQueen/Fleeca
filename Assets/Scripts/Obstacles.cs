using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{   
    [Header("Objects")]
    [SerializeField] GameObject start;
    [SerializeField] GameObject goal;
    [SerializeField] GameObject obstacle;

    [SerializeField] List<GameObject> obstacles;


    [Header("Stats")]
    [SerializeField] float minPathWidth = 1f;
    [SerializeField] int numPoints = 3;
    [SerializeField] int pointDensity;
    [SerializeField] float obstacleDensity = 0.50f;
    [SerializeField] float obstacleMult = 20f;
    [SerializeField] float maxSizeMult = 0.5f;
    [SerializeField] float absX = 9.8f;
    [SerializeField] float absY = 5.5f;
    
    [Header("Misc")]
    [SerializeField] List<Vector2> points;
    [SerializeField] List<Vector2> fullPoints;

    

    void Awake()
    {
        //Random rnd = new Random();
    }

    // Start is called before the first frame update
    void Start()
    {   
        pointDensity  = 3 + 2*(numPoints) ;
        points.Add(new Vector2(start.transform.position.x,start.transform.position.y));
        fullPoints.Add(new Vector2(start.transform.position.x,start.transform.position.y));
        SetPath();
        SetObstacles();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetObstacles(){
        for(int i = Mathf.CeilToInt(obstacleDensity*obstacleMult); i <= 0; i--)
        {   
            
            GameObject temp = Instantiate(obstacle, new Vector3(fullPoints[i].x, fullPoints[i].y, 0), Quaternion.identity)
            temp.transform.localscale(Random.range(0.1, maxSizeMult)*absX, Random.range(0.1, maxSizeMult)*absY, 0)
            foreach(GameObject ob in obstacles){
                if(temp.position.x  <=  && temp.position.y ){

                }
            }
            
            if(!){
                obstacles.Add(temp);
            }


        }

    }

    void SetPath()
    {   
        Vector2 sheesh;

        Debug.Log("Started Setpath");

        for(int i = 0; i < numPoints; i++){
            sheesh = new Vector2(Random.Range(-absX + minPathWidth/2, absX - minPathWidth/2), Random.Range(-absY + minPathWidth/2, absY - minPathWidth/2));
            points.Add(sheesh);
            fullPoints.Add(sheesh);
        }
        Debug.Log("Generated points");

        points.Add(new Vector2(goal.transform.position.x, goal.transform.position.y));
        fullPoints.Add(new Vector2(goal.transform.position.x, goal.transform.position.y));
        Debug.Log("added goal");


        for(int j = 0; j < pointDensity-1; j++){
            Debug.Log("Current Index: " + j);
            Debug.Log("Current Size: " + fullPoints);
            if(Random.Range(-1.0f, 1.0f) > 0){
                sheesh = new Vector2(fullPoints[j].x, fullPoints[j+1].y);
            }else{
                sheesh = new Vector2(fullPoints[j+1].x, fullPoints[j].y);
            }
            
            fullPoints.Insert(j+1, sheesh);
            j +=1;
        }

        Debug.Log("Added inbetween");

        //Comment out later
        for(int k = 0; k < pointDensity; k++){
            Instantiate(obstacle, new Vector3(fullPoints[k].x, fullPoints[k].y, 0), Quaternion.identity);
        }

    }


}
