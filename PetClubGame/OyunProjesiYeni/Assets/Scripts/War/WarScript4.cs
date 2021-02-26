using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class WarScript4 : MonoBehaviour
{
    public GameObject yourturn;
    public GameObject enemyturn;
    public GameObject miss;
    public GameObject win, lose;
    public GameObject skil1, skil2, skil3, skil4, skil5ot, skil5yanma, skil5et;
    public GameObject anaskiltext1, anaskiltext2, anaskiltext3, anaskiltext4kritik, anaskiltext4miss;
    public GameObject dusmanskiltext1, dusmanskiltext2, dusmanskiltext3, dusmanskiltext4, dusmanskiltext5;
    public GameObject level5;
    public GameObject anaskilyanma, anaskilot, anaskilet;

    public static bool savasbasladi=false;
    bool dusmanatak = false;
    bool karakteratak = false;

    int savas = 1;
    int randomdamage;

    private void Start()
    {
        
        yourturn.SetActive(true);
        karakteratak = true;
        Warbirdusmancan.dusmancan = 100;
        Warbiranakaraktercan.anacan = 100;
    }

    private void Update()
    {
        if (savasbasladi == true)
        {
            if (YemekScript.yemekdegeri == 50)
            {
                skil5ot.SetActive(false);
                skil5yanma.SetActive(true);
                skil5et.SetActive(false);
            }
            else if (YemekScript.yemekdegeri < 50)
            {
                skil5ot.SetActive(true);
                skil5yanma.SetActive(false);
                skil5et.SetActive(false);
            }
            if (YemekScript.yemekdegeri > 50)
            {
                skil5ot.SetActive(false);
                skil5yanma.SetActive(false);
                skil5et.SetActive(true);
            }
            savasbasladi = false;
        }
        if (karakteratak == false)
        {
            StartCoroutine("SkilDusman2");
            yourturn.SetActive(false);
            enemyturn.SetActive(true);
            skil1.SetActive(false);
            skil2.SetActive(false);
            skil3.SetActive(false);
            skil4.SetActive(false);
            skil5ot.SetActive(false);
            skil5yanma.SetActive(false);
            skil5et.SetActive(false);
            karakteratak = true;
        }
        if (Warbiranakaraktercan.anacan <= 0)
        {
            lose.SetActive(true);
            anaskiltext1.SetActive(false);
            anaskiltext2.SetActive(false);
            anaskiltext3.SetActive(false);
            anaskiltext4kritik.SetActive(false);
            anaskiltext4miss.SetActive(false);
            anaskilet.SetActive(false);
            anaskilot.SetActive(false);
            anaskilyanma.SetActive(false);
            dusmanskiltext1.SetActive(false);
            dusmanskiltext2.SetActive(false);
            dusmanskiltext3.SetActive(false);
            dusmanskiltext4.SetActive(false);
            dusmanskiltext5.SetActive(false);
        }
        if (Warbirdusmancan.dusmancan <= 0)
        {
            win.SetActive(true);
            anaskiltext1.SetActive(false);
            anaskiltext2.SetActive(false);
            anaskiltext3.SetActive(false);
            anaskiltext4kritik.SetActive(false);
            anaskiltext4miss.SetActive(false);
            anaskilet.SetActive(false);
            anaskilot.SetActive(false);
            anaskilyanma.SetActive(false);
            dusmanskiltext1.SetActive(false);
            dusmanskiltext2.SetActive(false);
            dusmanskiltext3.SetActive(false);
            dusmanskiltext4.SetActive(false);
            dusmanskiltext5.SetActive(false);
            level5.SetActive(true);
            savas = default;
            roadmapmanager.roadmapprefs = 4;
        }
    }

    public void LoseTekrarDene()
    {
        lose.SetActive(false);
        Warbiranakaraktercan.anacan = 100;
        Warbirdusmancan.dusmancan = 100;
    }

    void Dusmanswitch()
    {
        switch (savas)
        {
            case 1:


                Wartextdusman.textbool = true;

                dusmanskiltext1.SetActive(true);
                dusmanskiltext2.SetActive(false);
                dusmanskiltext3.SetActive(false);
                dusmanskiltext4.SetActive(false);
                dusmanskiltext5.SetActive(false);

                if (DayanıklılıkGameScript.anaekran >= 25 && Ceviklikgamescript.cevanaekran >= 20 && GucGameScript.gucanapuan >= 20)
                {

                    Warbiranakaraktercan.anacan -= 10;
                    MusicSoundScript.hitbool = false;
                }
                else
                {
                    Warbiranakaraktercan.anacan -= 30;
                    MusicSoundScript.hitbool = false;
                }


                break;
            case 2:


                Wartextdusman.textbool = true;

                dusmanskiltext1.SetActive(false);
                dusmanskiltext2.SetActive(true);
                dusmanskiltext3.SetActive(false);
                dusmanskiltext4.SetActive(false);
                dusmanskiltext5.SetActive(false);
                if (DayanıklılıkGameScript.anaekran >= 25 && Ceviklikgamescript.cevanaekran >= 25 && GucGameScript.gucanapuan >= 25)
                {

                    Warbiranakaraktercan.anacan -= 10;
                    MusicSoundScript.hitbool = false;
                }
                else
                {
                    Warbiranakaraktercan.anacan -= 30;
                    MusicSoundScript.hitbool = false;
                }

                break;
            case 3:




                Wartextdusman.textbool = true;

                dusmanskiltext1.SetActive(false);
                dusmanskiltext2.SetActive(false);
                dusmanskiltext3.SetActive(true);
                dusmanskiltext4.SetActive(false);
                dusmanskiltext5.SetActive(false);

                if (DayanıklılıkGameScript.anaekran >= 25 && Ceviklikgamescript.cevanaekran >= 25 && GucGameScript.gucanapuan >= 20)
                {

                    Warbiranakaraktercan.anacan -= 15;
                    MusicSoundScript.hitbool = false;
                }
                else
                {
                    Warbirdusmancan.dusmancan += 5;
                    Warbiranakaraktercan.anacan -= 25;
                    MusicSoundScript.hitbool = false;
                }
                break;
            case 4:



                Wartextdusman.textbool = true;

                dusmanskiltext1.SetActive(false);
                dusmanskiltext2.SetActive(false);
                dusmanskiltext3.SetActive(false);
                dusmanskiltext4.SetActive(true);
                dusmanskiltext5.SetActive(false);

                if (DayanıklılıkGameScript.anaekran >= 30 && Ceviklikgamescript.cevanaekran >= 25 && GucGameScript.gucanapuan >= 25)
                {

                    Warbiranakaraktercan.anacan -= 10;
                    MusicSoundScript.hitbool = false;
                }
                else
                {
                    Warbiranakaraktercan.anacan -= 25;
                    MusicSoundScript.hitbool = false;
                }

                break;
            case 5:



                Wartextdusman.textbool = true;

                dusmanskiltext1.SetActive(false);
                dusmanskiltext2.SetActive(false);
                dusmanskiltext3.SetActive(false);
                dusmanskiltext4.SetActive(false);
                dusmanskiltext5.SetActive(true);

                savas = 0;
                if (DayanıklılıkGameScript.anaekran >= 25 && Ceviklikgamescript.cevanaekran >= 25 && GucGameScript.gucanapuan >= 30)
                {

                    Warbiranakaraktercan.anacan -= 15;
                    MusicSoundScript.hitbool = false;
                }
                else
                {
                    Warbiranakaraktercan.anacan -= 30;
                    MusicSoundScript.hitbool = false;
                }

                break;
            default:

                break;
        }
    }

    IEnumerator SkilDusman2()
    {
        
        yield return new WaitForSeconds(6);
        Dusmanswitch();
        miss.SetActive(false);
        savas += 1;
        yield return new WaitForSeconds(3);
        yourturn.SetActive(true);
        enemyturn.SetActive(false);
        skil1.SetActive(true);
        skil2.SetActive(true);
        skil3.SetActive(true);
        skil4.SetActive(true);

    }

    public void Skilbir()
    {
        
        if (karakteratak == true)
        {
           
            karakteratak = false;
            randomdamage = Random.Range(0, 35);
            Warbirdusmancan.dusmancan -= randomdamage;
            Wartextanakarakter.textboolea = true;

            anaskiltext1.SetActive(true);
            anaskiltext2.SetActive(false);
            anaskiltext3.SetActive(false);
            anaskiltext4kritik.SetActive(false);
            anaskiltext4miss.SetActive(false);
            anaskilet.SetActive(false);
            anaskilot.SetActive(false);
            anaskilyanma.SetActive(false);
            MusicSoundScript.hitbool = false;
        }
    }

    public void Skiliki()
    {
        
        if (karakteratak == true)
        {
            MusicSoundScript.healbool = false;
            karakteratak = false;
            
            Warbiranakaraktercan.anacan += 20;
            Wartextanakarakter.textboolea = true;

            anaskiltext1.SetActive(false);
            anaskiltext2.SetActive(true);
            anaskiltext3.SetActive(false);
            anaskiltext4kritik.SetActive(false);
            anaskiltext4miss.SetActive(false);
            anaskilet.SetActive(false);
            anaskilot.SetActive(false);
            anaskilyanma.SetActive(false);

        }
    }

    public void Skiluc()
    {
       
        if (karakteratak == true)
        {
            
            karakteratak = false;
            Warbirdusmancan.dusmancan -= 25;
            Wartextanakarakter.textboolea = true;
            MusicSoundScript.hitbool = false;
            anaskiltext1.SetActive(false);
            anaskiltext2.SetActive(false);
            anaskiltext3.SetActive(true);
            anaskiltext4kritik.SetActive(false);
            anaskiltext4miss.SetActive(false);
            anaskilet.SetActive(false);
            anaskilot.SetActive(false);
            anaskilyanma.SetActive(false);
        }
    }

    public void Skildort()
    {
        
        if (karakteratak == true)
        {
            karakteratak = false;
            randomdamage = Random.Range(1, 6);
            if (randomdamage == 1)
            {
                miss.SetActive(true);
                Wartextanakarakter.textboolea = true;

                anaskiltext1.SetActive(false);
                anaskiltext2.SetActive(false);
                anaskiltext3.SetActive(false);
                anaskiltext4kritik.SetActive(false);
                anaskiltext4miss.SetActive(true);
                anaskilet.SetActive(false);
                anaskilot.SetActive(false);
                anaskilyanma.SetActive(false);

            }
            else if (randomdamage == 2)
            {
                Warbirdusmancan.dusmancan -= 50;
                Wartextanakarakter.textboolea = true;
                MusicSoundScript.hitbool = false;
                anaskiltext1.SetActive(false);
                anaskiltext2.SetActive(false);
                anaskiltext3.SetActive(false);
                anaskiltext4kritik.SetActive(true);
                anaskiltext4miss.SetActive(false);
                anaskilet.SetActive(false);
                anaskilot.SetActive(false);
                anaskilyanma.SetActive(false);

            }
            else if (randomdamage == 3)
            {
                miss.SetActive(true);
                Wartextanakarakter.textboolea = true;

                anaskiltext1.SetActive(false);
                anaskiltext2.SetActive(false);
                anaskiltext3.SetActive(false);
                anaskiltext4kritik.SetActive(false);
                anaskiltext4miss.SetActive(true);
                anaskilet.SetActive(false);
                anaskilot.SetActive(false);
                anaskilyanma.SetActive(false);

            }
            else if (randomdamage == 4)
            {
                Warbirdusmancan.dusmancan -= 50;
                Wartextanakarakter.textboolea = true;
                MusicSoundScript.hitbool = false;
                anaskiltext1.SetActive(false);
                anaskiltext2.SetActive(false);
                anaskiltext3.SetActive(false);
                anaskiltext4kritik.SetActive(true);
                anaskiltext4miss.SetActive(false);
                anaskilet.SetActive(false);
                anaskilot.SetActive(false);
                anaskilyanma.SetActive(false);

            }
            else if (randomdamage == 5)
            {
                miss.SetActive(true);
                Wartextanakarakter.textboolea = true;

                anaskiltext1.SetActive(false);
                anaskiltext2.SetActive(false);
                anaskiltext3.SetActive(false);
                anaskiltext4kritik.SetActive(false);
                anaskiltext4miss.SetActive(true);
                anaskilet.SetActive(false);
                anaskilot.SetActive(false);
                anaskilyanma.SetActive(false);

            }
        }
    }
    public void skilbes()
    {



        if (YemekScript.yemekdegeri < 50)
        {


            if (karakteratak == true)
            {

                karakteratak = false;
                Warbirdusmancan.dusmancan -= 10;
                Warbiranakaraktercan.anacan += 10;
                Wartextanakarakter.textboolea = true;
                MusicSoundScript.hitbool = false;
                anaskiltext1.SetActive(false);
                anaskiltext2.SetActive(false);
                anaskiltext3.SetActive(false);
                anaskiltext4kritik.SetActive(false);
                anaskiltext4miss.SetActive(false);
                anaskilet.SetActive(false);
                anaskilot.SetActive(true);
                anaskilyanma.SetActive(false);


            }

        }
        else if (YemekScript.yemekdegeri > 50)
        {

            if (karakteratak == true)
            {

                karakteratak = false;
                Warbirdusmancan.dusmancan -= 30;
                Wartextanakarakter.textboolea = true;
                MusicSoundScript.hitbool = false;
                anaskiltext1.SetActive(false);
                anaskiltext2.SetActive(false);
                anaskiltext3.SetActive(false);
                anaskiltext4kritik.SetActive(false);
                anaskiltext4miss.SetActive(false);
                anaskilet.SetActive(true);
                anaskilot.SetActive(false);
                anaskilyanma.SetActive(false);

            }


        }
        else if (YemekScript.yemekdegeri == 50)
        {

            if (karakteratak == true)
            {
                MusicSoundScript.hitbool = false;
                karakteratak = false;
                Warbirdusmancan.dusmancan -= 20;
                Wartextanakarakter.textboolea = true;
                anaskiltext1.SetActive(false);
                anaskiltext2.SetActive(false);
                anaskiltext3.SetActive(false);
                anaskiltext4kritik.SetActive(false);
                anaskiltext4miss.SetActive(false);
                anaskilet.SetActive(false);
                anaskilot.SetActive(false);
                anaskilyanma.SetActive(true);
            }
        }
    }
}
