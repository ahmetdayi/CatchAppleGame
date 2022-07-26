using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScreenManager : MonoBehaviour
{
    public GameObject startScreen;
    void Start()
    {
       
      
           
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= 1.0f)
        {
            startScreen.SetActive(true);
        }
        
    }

    public void PushStartBtn()
    {
        SceneManager.LoadScene("Scenes/GameScene");
    }

   
}
