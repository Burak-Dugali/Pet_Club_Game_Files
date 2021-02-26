using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class roadmapmanager : MonoBehaviour
{
    public GameObject Roadmapmain;
    public GameObject Maingame;
    public GameObject MainBackButton;
    public static int roadmapprefs=0;

    public GameObject Savas1Kale,savas2kale, savas3kale, savas4kale, savas5kale;
    public GameObject sav1strt, sav2strt, sav3strt, sav4strt, sav5strt;
    public RectTransform savas1, savas2, savas3, savas4, savas5;
    public GameObject savas1ana,savas2ana, savas3ana, savas4ana, savas5ana;
    public GameObject savas1arena;
    public GameObject savas1win,savas2win, savas3win, savas4win, savas5win;
    public GameObject War1Manager,war2manager, war3manager, war4manager, war5manager;
   
    private void Start()
    {
        roadmapprefs = PlayerPrefs.GetInt("warprefs");
        war2manager.SetActive(false);
    }
    private void Update()
    {
        PlayerPrefs.SetInt("warprefs", roadmapprefs);
        if(roadmapprefs==1)
        {
            savas2kale.SetActive(true);
            savas1win.SetActive(true);
        }
        else if(roadmapprefs==2)
        {
            savas3kale.SetActive(true);
            savas2win.SetActive(true);
            savas2kale.SetActive(true);
            savas1win.SetActive(true);
        }
        else if(roadmapprefs==3)
        {
            savas4kale.SetActive(true);
            savas3win.SetActive(true);
            savas3kale.SetActive(true);
            savas2win.SetActive(true);
            savas2kale.SetActive(true);
            savas1win.SetActive(true);
        }
        else if(roadmapprefs==4)
        {
            savas5kale.SetActive(true);
            savas4win.SetActive(true);
            savas4kale.SetActive(true);
            savas3win.SetActive(true);
            savas3kale.SetActive(true);
            savas2win.SetActive(true);
            savas2kale.SetActive(true);
            savas1win.SetActive(true);
        }
        else if(roadmapprefs==5)
        {
            savas5kale.SetActive(true);
            savas5win.SetActive(true);
            savas5kale.SetActive(true);
            savas4win.SetActive(true);
            savas4kale.SetActive(true);
            savas3win.SetActive(true);
            savas3kale.SetActive(true);
            savas2win.SetActive(true);
            savas2kale.SetActive(true);
            savas1win.SetActive(true);
        }
        if(MainMenuScript.OyunSifirlayici==true)
        {
            roadmapprefs = 0;
            savas5kale.SetActive(false);
            savas5win.SetActive(false);
            savas5kale.SetActive(false);
            savas4win.SetActive(false);
            savas4kale.SetActive(false);
            savas3win.SetActive(false);
            savas3kale.SetActive(false);
            savas2win.SetActive(false);
            savas2kale.SetActive(false);
            savas1win.SetActive(false);
        }
    }
    public void RoadMapOpen()
    {
        Maingame.SetActive(false);
        Roadmapmain.SetActive(true);
       
    }
    public void roadmapbackbutton()
    {
        Maingame.SetActive(true);
        Roadmapmain.SetActive(false);
         
    }

    public void savasbir()
    {
        StartCoroutine(savasbirdelay());   
        savas1arena.SetActive(false);
        Warbiranakaraktercan.anacan = 100;
        Warbirdusmancan.dusmancan = 100;
        savas1ana.SetActive(true);
        savas1.DOAnchorPos(Vector2.zero, 0.25f);
        MainBackButton.SetActive(false);
        MusicSoundScript.warbool = false;
        MusicSoundScript.roadmapstop = false;
    }
    IEnumerator savasbirdelay()
    {
        yield return new WaitForSeconds(8);
        MusicSoundScript.fightbool = false;
        yield return new WaitForSeconds(1);
        Warbiranakaraktercan.anacan = 100;
        Warbirdusmancan.dusmancan = 100;
        sav1strt.SetActive(false);
        war2manager.SetActive(false);
        war3manager.SetActive(false);
        war4manager.SetActive(false);
        war5manager.SetActive(false);
    }
    IEnumerator savasikidelay()
    {
        yield return new WaitForSeconds(8);
        MusicSoundScript.fightbool = false;
        yield return new WaitForSeconds(1);
        Warbiranakaraktercan.anacan = 100;
        Warbirdusmancan.dusmancan = 100;
        sav2strt.SetActive(false);
        War1Manager.SetActive(false);
        war2manager.SetActive(true);
        war3manager.SetActive(false);
        war4manager.SetActive(false);
        war5manager.SetActive(false);
    }
    IEnumerator savasucdelay()
    {
        yield return new WaitForSeconds(8);
        MusicSoundScript.fightbool = false;
        yield return new WaitForSeconds(1);
        Warbiranakaraktercan.anacan = 100;
        Warbirdusmancan.dusmancan = 100;
        sav3strt.SetActive(false);
        War1Manager.SetActive(false);
        war2manager.SetActive(false);
        war3manager.SetActive(true);
        war4manager.SetActive(false);
        war5manager.SetActive(false);
    }
    IEnumerator savasdortdelay()
    {
        yield return new WaitForSeconds(8);
        MusicSoundScript.fightbool = false;
        yield return new WaitForSeconds(1);
        Warbiranakaraktercan.anacan = 100;
        Warbirdusmancan.dusmancan = 100;
        sav4strt.SetActive(false);
        War1Manager.SetActive(false);
        war2manager.SetActive(false);
        war3manager.SetActive(false);
        war4manager.SetActive(true);
        war5manager.SetActive(false);
    }
    IEnumerator savasbesdelay()
    {
        yield return new WaitForSeconds(8);
        MusicSoundScript.fightbool = false;
        yield return new WaitForSeconds(1);
        Warbiranakaraktercan.anacan = 100;
        Warbirdusmancan.dusmancan = 100;
        sav5strt.SetActive(false);
        War1Manager.SetActive(false);
        war2manager.SetActive(false);
        war3manager.SetActive(false);
        war4manager.SetActive(false);
        war5manager.SetActive(true);
    }

    public void savasbirexit()
    {
        savas1.DOAnchorPos(new Vector2(-1920, 0), 0.25f);
        MainBackButton.SetActive(true);
        MusicSoundScript.warbool2 = false;
        MusicSoundScript.roadmapstart = false;
    }


    

    public void savasiki()
    {
        StartCoroutine(savasikidelay());
        WarScript2.savasbasladi = true;
        savas1arena.SetActive(false);
        Warbiranakaraktercan.anacan = 100;
        Warbirdusmancan.dusmancan = 100;
        savas2ana.SetActive(true);
        savas2.DOAnchorPos(Vector2.zero, 0.25f);
        MainBackButton.SetActive(false);
        MusicSoundScript.warbool = false;
        MusicSoundScript.roadmapstop = false;
    }

    public void savasikiexit()
    {
        savas2.DOAnchorPos(new Vector2(-1920, 0), 0.25f);
        MainBackButton.SetActive(true);
        MusicSoundScript.warbool2 = false;
        MusicSoundScript.roadmapstart = false;
    }


  

    public void savasuc()
    {
        StartCoroutine(savasucdelay());
        WarScript3.savasbasladi = true;
        savas1arena.SetActive(false);   
        Warbiranakaraktercan.anacan = 100;
        Warbirdusmancan.dusmancan = 100;
        savas2ana.SetActive(false);
        savas3ana.SetActive(true);
        savas3.DOAnchorPos(Vector2.zero, 0.25f);
        MainBackButton.SetActive(false);
        MusicSoundScript.warbool = false;
        MusicSoundScript.roadmapstop = false;
    }

    public void savasucexit()
    {

        savas3.DOAnchorPos(new Vector2(-1920, 0), 0.25f);
        MainBackButton.SetActive(true);
        MusicSoundScript.warbool2 = false;
        MusicSoundScript.roadmapstart = false;
    }
    

    public void savasdort()
    {

        StartCoroutine(savasdortdelay());
        savas1arena.SetActive(false);       
        Warbiranakaraktercan.anacan = 100;
        Warbirdusmancan.dusmancan = 100;
        savas2ana.SetActive(false);
        savas3ana.SetActive(false);
        savas4ana.SetActive(true);
        savas4.DOAnchorPos(Vector2.zero, 0.25f);
        MainBackButton.SetActive(false);
        WarScript4.savasbasladi = true;
        MusicSoundScript.warbool = false;
        MusicSoundScript.roadmapstop = false;
    }

    public void savasdortexit()
    {

        savas4.DOAnchorPos(new Vector2(-1920, 0), 0.25f);
        MainBackButton.SetActive(true);
        MusicSoundScript.warbool2 = false;
        MusicSoundScript.roadmapstart = false;
    }
    public void savasbesexit()
    {

        savas5.DOAnchorPos(new Vector2(-1920, 0), 0.25f);
        MainBackButton.SetActive(true);
        MusicSoundScript.warbool2 = false;
        MusicSoundScript.roadmapstart = false;
    }
  
    public void savasbes()
    {
        StartCoroutine(savasbesdelay());
        WarScript5.savasbasladi = true;
        savas1arena.SetActive(false);
        Warbiranakaraktercan.anacan = 100;
        Warbirdusmancan.dusmancan = 100;
        savas2ana.SetActive(false);
        savas3ana.SetActive(false);
        savas4ana.SetActive(false);
        savas5ana.SetActive(true);
        savas5.DOAnchorPos(Vector2.zero, 0.25f);
        MainBackButton.SetActive(false);
        MusicSoundScript.warbool = false;
        MusicSoundScript.roadmapstop = false;
    }
}
