using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TierraController : MonoBehaviour
{
    float number;
    public Image redHeart;
    float startingheal = 100f;
    float actualHeal = 100f;
    public GameObject gameOverImage;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("apple"))
        {
           Destroy(collision.gameObject);
            HeartMechanic();

        }
    }

    private void Start()
    {
      
    }

    void HeartMechanic()
    {
        actualHeal -= 10f;
        redHeart.fillAmount = actualHeal/startingheal;
        if(actualHeal == 0)
        {
            
            Time.timeScale = 0f;
            gameOverImage.SetActive(true);
        }
    }
}
