using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallonSpawner : MonoBehaviour
{
    public float minX, maxX;
    public GameObject[] Balloons;

    public float MaxTime;
    float currentTime =0;
  
    
    void Update()
    {
        currentTime = currentTime + Time.deltaTime; 
        if(currentTime>=MaxTime)
        {
            currentTime = 0;
            GameObject  obj = Instantiate(Balloons[Random.Range(0, Balloons.Length)], 
            new Vector3(Random.Range(minX,maxX),this.transform.position.y,this.transform.position.z),Quaternion.identity);
            obj.transform.SetParent(gameObject.transform);

        }

    
    }
}
