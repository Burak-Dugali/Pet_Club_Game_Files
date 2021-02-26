using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using DG.Tweening;

/// <summary>
/// Bu kısımda dayanıklılık oyunumuzun kodları bulunmaktadır . - Emre - Dinçer 
/// </summary>

public class DayanıklılıkGameScript : MonoBehaviour
{
    
    public GameObject ClıckerBtn;
    public GameObject StarterBtn;
    public GameObject geridonuskapalı;
    public GameObject Acıklamametni;
    public GameObject süre;
    [SerializeField] Text gerisayım;
    public static float currenttime=0f;
                  float startingtime=30f;
    public static bool isgamestarted;
    public static bool isgameearned;
    
    
    public Text dayaniklilikanapuan;
    public Text dayaniklilikanapuanfight, dayaniklilikanapuanfight2, dayaniklilikanapuanfight3, dayaniklilikanapuanfight4, dayaniklilikanapuanfight5;
    public Text bitisekranıpuan;
   


    public int a = 1;
    public int b = 2;
    public int c = -1;
    int dayaniklilikPrefsDegeri;

    public static int anaekran;
    int randomnbr;
    bool timercontroller = false;

    public RectTransform dayanıklılıkoyunsonu;
    public RectTransform dayanıklılıkoyun;

    void Start()
    {
        isgamestarted = false;
        isgameearned = false;
        currenttime = startingtime;
        ClıckerBtn.SetActive(false);
        dayaniklilikPrefsDegeri = PlayerPrefs.GetInt("DayaniklilikAnaskor");
    }
    void Update()
    {
        PlayerPrefs.SetInt("DayaniklilikAnaskor",dayaniklilikPrefsDegeri);
        dayaniklilikanapuanfight.text = dayaniklilikPrefsDegeri.ToString();
        dayaniklilikanapuanfight2.text = dayaniklilikPrefsDegeri.ToString();
        dayaniklilikanapuanfight3.text = dayaniklilikPrefsDegeri.ToString();
        dayaniklilikanapuanfight4.text = dayaniklilikPrefsDegeri.ToString();
        dayaniklilikanapuanfight5.text = dayaniklilikPrefsDegeri.ToString();
        dayaniklilikanapuan.text = dayaniklilikPrefsDegeri.ToString();
        if (isgamestarted)
        {
            timercontroller = true;
            timer();
            
        }
    }
    public void DayanıklılıkGame()
    {
        /// stamina değeri düşürülecek
        DayanıklılıkGameSkor.clickdegeri ++;
        randomnbr = Random.Range(0, 100);
        if(randomnbr<5)
        {
            Money.money++;
        }
    }

    public void StartBtn()
    {
        if(StaminaSystem.stamin<=0)
        {
            Debug.Log("null");
            //buraya eğer stamina yoksa ekrana bir yazı paneli açtırma yapılıcak.
        }
        else
        {
            isgamestarted = true;
            isgameearned = true;
            ClıckerBtn.SetActive(true);
            StarterBtn.SetActive(false);
            süre.SetActive(true);
            Acıklamametni.SetActive(false);
            StaminaSystem.stamin -= 10;
        }

    }
    public void timer()
    {
        
        if(timercontroller==true)
        {
            geridonuskapalı.SetActive(false);
            currenttime -= 1 * Time.deltaTime;
            gerisayım.text = currenttime.ToString("0");
            if (currenttime < 6)
            {
                gerisayım.color = Color.red;
            }
            if (currenttime <= 0)
            {
                geridonuskapalı.SetActive(true);
                dayanıklılıkoyunsonu.DOAnchorPos(new Vector2(0, 0), 0.25f);  
                dayanıklılıkoyun.DOAnchorPos(new Vector2(1920, 0), 0.25f);
                isgamestarted = false;
                timercontroller = false;
                gerisayım.color = Color.black;
                if (DayanıklılıkGameSkor.clickdegeri >= 100)
                {
                    anaekran=anaekran+2;
                    bitisekranıpuan.text =  b.ToString();
                }
                else if (DayanıklılıkGameSkor.clickdegeri >= 60)
                {
                    anaekran=anaekran+1;
                    bitisekranıpuan.text = a.ToString();
                }
                else if(DayanıklılıkGameSkor.clickdegeri < 60)
                {
                    anaekran=anaekran-1;
                    bitisekranıpuan.text = c.ToString();        
                }
                dayaniklilikPrefsDegeri=anaekran;

            }     
        }      
    }
}
