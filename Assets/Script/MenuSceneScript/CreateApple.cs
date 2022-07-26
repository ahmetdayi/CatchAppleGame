using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateApple : MonoBehaviour
{

    public GameObject apple;
    float number;
    public float timeInterval;
   
    void Start()
    {
        InvokeRepeating("Create_apple", 0f, timeInterval);
    }

    void Update()
    {
        
    }

    void Create_apple()
    {
        number = Random.Range(-8.0f, 6.5f);
        GameObject newApple = Instantiate(apple,new Vector3(number, 9, 13), Quaternion.identity);
    }



}
