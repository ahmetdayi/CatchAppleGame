using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketRandomMove : MonoBehaviour
{
    float basketPosition;
    float number;
    public float basketSpeed;


    private void Update()
    {
        Basket_random_move();

    }
    void Basket_random_move()
    {
        transform.Translate(new Vector3(basketSpeed * Time.deltaTime, 0, 0));
        if (transform.position.x >= 11)
        {
            transform.position = new Vector3(-8.5f, -0.0521f,-1.28f);
           
        }
       if(transform.position.x <= -9f)
        {
            transform.position = new Vector3(10.5f, -0.0521f, -1.28f);
           
        }
    }

    
}
