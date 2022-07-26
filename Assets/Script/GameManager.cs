using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

            //UI
//-----------------------------------------------------------------------------
//eger u�larda koyacag�m�z component nesneyle beraber hareket edecekse(dusman�n uzer�nde gozuken can bar� g�b�) canvas rendered moddan world space sec�l�r
//eger sab�t olmas�n� �st�yorsak screen space sec�l�r
//canvas scalerdek� u� scale modunu eger scale with screen size yaparsak ekran boyutuna gore otomat�k ayarlan�r .
//referance resulation k�sm�na da oyunu hang� cozunurlukte yap�yosan�z onu g�r�n
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
            restTime = timeInterval + Time.time;//bu sek�lde de elma uret�leb�l�r oyun zaman�n� kullanarak
            //sialhla ates ed�lmes�n� ayarlarken kullan�lab�l�r.
        }
    }

    public void pauseBtnFunc()
    {
        //oncl�ck event� butona t�klay�p b�rak�ld�g�nda cal�s�r eger farkl� cal�smas� �sten�yorsa 
        //event trigger component� butona eklen�r
        /////////////////////////////////////event trigger
        //pointerenter mouse butonun uzer�ne geld�g�nde cal�s�r
        //pointerexist mouse butonun uzer�nden cek�ld�g� an cal�s�r
        //pointerdown sol mouse tusuyla t�kland�g�nda cal�s�r
        //pointerup sag mouse tusuyla t�kland�g�nda cal�s�r
        //drag sol mouse �le t�klan�p mouse hareket ett�r�ld�g�nde cal�s�r
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
