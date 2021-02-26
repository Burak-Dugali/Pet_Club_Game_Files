using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class GucGameScript : MonoBehaviour
{
    public GameObject ClıckerBtn;
    public GameObject StarterBtn;
    public GameObject geridonuskapalı;
    public GameObject Acıklamametni;
    public GameObject süre;
    public GameObject nostamina;


    public GameObject guccanvas;
    public RectTransform gucbaslangıcekranı;
    public RectTransform gucgamescreen;
    
    [SerializeField] Text gerisayım;
    public Text bitisekranıpuan;

    public static float currenttime = 0f;
    float startingtime = 30f;
    public static bool isgamestarted;
    public static bool isgameearned;

    public Text gucmainskor;
    public Text gucmainskorfight, gucmainskorfight2, gucmainskorfight3, gucmainskorfight4, gucmainskorfight5;
    public Text gucleveltxt;
    public Text gucingamelevel;
    public GameObject roadmap;
    
     int a = 1;
     int b = 2;
     int c = -1;
    int Prefsdegeri;

    public static int Guclevel=0;
    public static int gucanapuan;

    bool timercontroller = false;
    bool startcont = false;

    public RectTransform gucoyunsonu;
    public GameObject gucoyun;
    
    void Start()
    {
        isgamestarted = false;
        isgameearned = false;
        currenttime = startingtime;
        gucanapuan = PlayerPrefs.GetInt("GucAnaSkor");
    }

   
    void Update()
    {
        PlayerPrefs.SetInt("GucAnaSkor", gucanapuan);
        gucmainskor.text = gucanapuan.ToString();
        gucmainskorfight.text = gucanapuan.ToString();
        gucmainskorfight2.text = gucanapuan.ToString();
        gucmainskorfight3.text = gucanapuan.ToString();
        gucmainskorfight4.text = gucanapuan.ToString();
        gucmainskorfight5.text = gucanapuan.ToString();
        if (isgamestarted)
        {
            timercontroller = true;
            timer();
            gucleveltxt.text=Guclevel.ToString();
            gucingamelevel.text=gucleveltxt.text;
        }
        if (MainMenuScript.OyunSifirlayici == true)
        {
            gucanapuan = 0;
        }
    }
    IEnumerator Nostamina()
    {
        startcont = true;
        nostamina.SetActive(true);
        yield return new WaitForSeconds(1f);
        nostamina.SetActive(false);
        StopCoroutine(Nostamina());
        startcont = false;
    }

    public void StartBtn()
    {
        if (startcont == false)
        { 
            if (StaminaSystem.stamin <= 0)
            {
                StartCoroutine(Nostamina());
            }
            else
            {
                isgamestarted = true;
                isgameearned = true;
                gucbaslangıcekranı.DOAnchorPos(new Vector2(1920, 0), 0.25f);
                gucgamescreen.DOAnchorPos(new Vector2(0, 0), 0.25f);
                roadmap.SetActive(false);
                süre.SetActive(true);
                StaminaSystem.stamin -= 10;
            }
        }
    }

    public void timer()
    {   
        if (timercontroller == true)
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
                gucoyunsonu.DOAnchorPos(new Vector2(0, 0), 0.25f);
                gucgamescreen.DOAnchorPos(new Vector2(-1920, 0), 0.25f);
                
                isgamestarted = false;
                timercontroller = false;
                gerisayım.color = Color.black;
                GucBarScript.hız=0.37f;
                if(Guclevel>=5)
                {
                    gucanapuan=gucanapuan+2;
                    bitisekranıpuan.text =  b.ToString();
                }
                else if(Guclevel>2)
                {
                    gucanapuan=gucanapuan+1;
                    bitisekranıpuan.text =  a.ToString();
                }
                else if(Guclevel<=2)
                {
                    gucanapuan=gucanapuan-1;
                    bitisekranıpuan.text =  c.ToString();
                }
                GucBarScript.say=0;
                gucleveltxt.text=Guclevel.ToString();
            }
        }
    }
    
}
