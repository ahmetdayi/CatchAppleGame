using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BasketController : MonoBehaviour
{

    public float basketSpeed;
    int score = 0;
    float number;
    public TextMeshProUGUI scoreText;




    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag.Equals("apple"))
        {
            score += 10;
            
            scoreText.text = "Score : " + score.ToString();
            Destroy(collision.gameObject);
            
        }
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(basketSpeed * Time.deltaTime,0,0);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-basketSpeed * Time.deltaTime, 0, 0);
        }

        BasketMoveController();


    }

    void BasketMoveController()
    {
        if(transform.position.x >= 9.39f )
        {
            transform.position = new Vector3(-8.5f, 0.13f, 11.59f);
        } 
        if(transform.position.x <= -9f)
        {
            transform.position = new Vector3(9.39f, 0.13f, 11.59f);
        }
    }
}
