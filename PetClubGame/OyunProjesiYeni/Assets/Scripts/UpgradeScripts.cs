using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.SceneManagement;
/// <summary>
/// Bu kısımda main game screenimizde olacak etkinlikler yer alıyor. - Emre - Dinçer 
/// </summary>

public class UpgradeScripts : MonoBehaviour
{
    public GameObject UpgradeSystem;
    public GameObject Yemek;
    public GameObject Güc;
    public GameObject MenuCanvas;
    public GameObject MainGameCanvas;
    public GameObject Karakter;
    public GameObject anapanel;
    public GameObject roadmapCanvas;
    public GameObject gametomenu;
    

    public Text ZekaAnaPuan,zekaanapuanfight1, zekaanapuanfight2, zekaanapuanfight3, zekaanapuanfight4, zekaanapuanfight5;

    public GameObject ceviklikgamestart,ceviklikoyunbitimi,cevgamescreen,cevpuanbutton;
    public GameObject cevsayac,cevskor;
    public GameObject roadmap;
    public RectTransform Ceviklikgamescreen;
    public RectTransform Ceviklikbitisekranı;
    public RectTransform gucbaslangıcekranı;
    public RectTransform gucgamescreen;
    public RectTransform gucfinishScreen;
    public RectTransform upgradepanel;
    public RectTransform Marketpanel;

    public static int zekacontroller;
    int zekadegeri;

    private void Start()
    {
        zekadegeri = PlayerPrefs.GetInt("ZekaAnapuan");
        zekadegeri = zekadegeri + ZekaOyunuScript.PrefsDegeri;
        if (PlayerPrefs.HasKey("zekaController"))
        {
            MainGameCanvas.SetActive(true);
            MenuCanvas.SetActive(false);
            StartCoroutine(Delay());
        }
    }
    IEnumerator Delay()
    {
        yield return new WaitForSeconds(0.5f);
        PlayerPrefs.DeleteKey("zekaController");
        zekacontroller = default;
        StopCoroutine(Delay());
    }
    private void Update()
    {
        Debug.Log(ZekaOyunuScript.PrefsDegeri);
        if (MainMenuScript.OyunSifirlayici == true)
        {
            zekadegeri = 0;
        }
        PlayerPrefs.SetInt("ZekaAnapuan", zekadegeri);
        ZekaAnaPuan.text = zekadegeri.ToString();
        zekaanapuanfight1.text= zekadegeri.ToString();
        zekaanapuanfight2.text = zekadegeri.ToString();
        zekaanapuanfight3.text = zekadegeri.ToString();
        zekaanapuanfight4.text = zekadegeri.ToString();
        zekaanapuanfight5.text = zekadegeri.ToString();
    }
    public void GametoMenu()
    {
        MainGameCanvas.SetActive(false);
        MenuCanvas.SetActive(true);
    }
    public void yemekgame()
    {
        anapanel.SetActive(false);
        Karakter.SetActive(false);
        PlayerPrefs.DeleteKey("zekaController");
        zekacontroller = default;
        Yemek.SetActive(true);
        gametomenu.SetActive(false);


    }
    public void gücgame()
    {
        gucbaslangıcekranı.DOAnchorPos(new Vector2(0, 0), 0.25f);
        upgradepanel.DOAnchorPos(new Vector2(-1920, 0), 0.25f);
        roadmap.SetActive(false);
        Karakter.SetActive(false);
        PlayerPrefs.DeleteKey("zekaController");
        zekacontroller = default;
        MusicSoundScript.gucstart = false;
        MusicSoundScript.maingamestop = false;
    }
    
    public void dayanıklılıkgame()
    {
        SceneManager.LoadScene("CardGame",LoadSceneMode.Additive);
        MainGameCanvas.SetActive(false);
        zekacontroller = 1;
        PlayerPrefs.SetInt("zekaController",zekacontroller);
        MusicSoundScript.maingamestop = false;
        MusicSoundScript.zekastart = false;
    }
    public void ceviklilikgame()
    {
        
        Ceviklikgamescreen.DOAnchorPos(new Vector2(0, 0), 0.25f);
        roadmap.SetActive(false);
        upgradepanel.DOAnchorPos(new Vector2(-1920, 0), 0.25f);
        Karakter.SetActive(false);
        PlayerPrefs.DeleteKey("zekaController");
        zekacontroller = default;
        MusicSoundScript.ceviklikstart=false;
        MusicSoundScript.maingamestop = false;
    }
    public void backtogucmenu()  
    {
        gucfinishScreen.DOAnchorPos(new Vector2(-1920, 0), 0.25f);
        gucgamescreen.DOAnchorPos(new Vector2(1920, 0), 0.25f);
        gucbaslangıcekranı.DOAnchorPos(new Vector2(1920, 0), 0.25f);
        UpgradeSystem.SetActive(true);
        GucGameScript.currenttime=30;
        GucGameScript.Guclevel = 0;
        GucDeneme.currentHealth=0;
        roadmap.SetActive(true);
        upgradepanel.DOAnchorPos(new Vector2(0, 0), 0.25f);
        Karakter.SetActive(true);
        MusicSoundScript.maingamestart = false;
        MusicSoundScript.gucstop = false;
    }

    public void backtoceviklik()
    {
       
        UpgradeSystem.SetActive(true);
        ceviklikgamestart.SetActive(true);
        Ceviklikbitisekranı.DOAnchorPos(new Vector2(-1920, 0), 0.25f);
        Ceviklikgamescreen.DOAnchorPos(new Vector2(1920, 0), 0.25f);
        Ceviklikgamescript.currenttime = 30;  
        CeviklikGameScore.cevclickdegeri = 0;
        cevsayac.SetActive(false);
        roadmap.SetActive(true);
        upgradepanel.DOAnchorPos(new Vector2(0, 0), 0.25f);
        Karakter.SetActive(true);
        MusicSoundScript.maingamestart = false;
        MusicSoundScript.ceviklikstop = false;
    }
    public void backtoyemekmenu()
    {
        anapanel.SetActive(true);
        Yemek.SetActive(false);
        UpgradeSystem.SetActive(true);
        Karakter.SetActive(true);
        gametomenu.SetActive(true);
    }
    public void backmenu()
    {
        MainGameCanvas.SetActive(false);
        MenuCanvas.SetActive(true);
    }
    public void roadMapbutton()
    {
        MainGameCanvas.SetActive(false);
        roadmapCanvas.SetActive(true);
        PlayerPrefs.DeleteKey("zekaController");
        zekacontroller = default;
        MusicSoundScript.roadmapstart = false;
    }

}
