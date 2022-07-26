using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

            //UI
//-----------------------------------------------------------------------------
//eger uýlarda koyacagýmýz component nesneyle beraber hareket edecekse(dusmanýn uzerýnde gozuken can barý gýbý) canvas rendered moddan world space secýlýr
//eger sabýt olmasýný ýstýyorsak screen space secýlýr
//canvas scalerdeký uý scale modunu eger scale with screen size yaparsak ekran boyutuna gore otomatýk ayarlanýr .
//referance resulation kýsmýna da oyunu hangý cozunurlukte yapýyosanýz onu gýrýn
//---------------------------------------------------------------------------------
public class GameManager : MonoBehaviour
{
    public GameObject apple;
    float number;
    public float repeatTime;
    private float restTime = 0.0f;
    private float timeInterval = 0.9f;
    bool isPauseGame = false;
    public GameObject pauseScreen;



    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {

        if (Time.time >= restTime)
        {
            ProductApple();
            restTime = timeInterval + Time.time;//bu sekýlde de elma uretýlebýlýr oyun zamanýný kullanarak
            //sialhla ates edýlmesýný ayarlarken kullanýlabýlýr.
        }
    }

    public void pauseBtnFunc()
    {
        //onclýck eventý butona týklayýp býrakýldýgýnda calýsýr eger farklý calýsmasý ýstenýyorsa 
        //event trigger componentý butona eklenýr
        /////////////////////////////////////event trigger
        //pointerenter mouse butonun uzerýne geldýgýnde calýsýr
        //pointerexist mouse butonun uzerýnden cekýldýgý an calýsýr
        //pointerdown sol mouse tusuyla týklandýgýnda calýsýr
        //pointerup sag mouse tusuyla týklandýgýnda calýsýr
        //drag sol mouse ýle týklanýp mouse hareket ettýrýldýgýnde calýsýr
        //-----------------------------------------------------------------
        isPauseGame = !isPauseGame;

        if (isPauseGame)
        {
            Time.timeScale = 0.0f;
            pauseScreen.SetActive(true);

        }
        else
        {
            Time.timeScale = 1.0f;
            pauseScreen.SetActive(false);
        }

    }

   

    void ProductApple()
    {
        number = Random.Range(-8f, 6.5f);
        GameObject newApple = Instantiate(apple,new Vector3(number,9,13),Quaternion.identity);
    }


    public void pushMenuBtn()
    {
        SceneManager.LoadScene("Scenes/MenuScene");
        Time.timeScale = 1.0f;
    }
}
