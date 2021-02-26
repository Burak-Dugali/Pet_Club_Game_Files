using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class WarScript : MonoBehaviour
{
    public GameObject yourturn;
    public GameObject enemyturn;
    public GameObject miss;
    public GameObject win, lose;
    public GameObject skil1, skil2, skil3, skil4;
    public GameObject anaskiltext1, anaskiltext2, anaskiltext3,anaskiltext4kritik,anaskiltext4miss;
    public GameObject dusmanskiltext1, dusmanskiltext2, dusmanskiltext3, dusmanskiltext4, dusmanskiltext5;
    public GameObject level2;

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
    // WİN LOSE OLAYLARI KAYITTA TUTULACAK
    private void Update()
    {      
        if (karakteratak == false)
        {
            StartCoroutine("SkilDusman");
            yourturn.SetActive(false);
            enemyturn.SetActive(true);
            skil1.SetActive(false);
            skil2.SetActive(false);
            skil3.SetActive(false);
            skil4.SetActive(false);           
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
            dusmanskiltext1.SetActive(false);
            dusmanskiltext2.SetActive(false);
            dusmanskiltext3.SetActive(false);
            dusmanskiltext4.SetActive(false);
            dusmanskiltext5.SetActive(false);
            level2.SetActive(true);
            roadmapmanager.roadmapprefs = 1;
            savas = default;

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
                Warbiranakaraktercan.anacan -= 15;
                MusicSoundScript.hitbool = false;
                Wartextdusman.textbool = true;

                dusmanskiltext1.SetActive(true);
                dusmanskiltext2.SetActive(false);
                dusmanskiltext3.SetActive(false);
                dusmanskiltext4.SetActive(false);
                dusmanskiltext5.SetActive(false);

                break;
            case 2:
                Warbiranakaraktercan.anacan -= 10;
                MusicSoundScript.hitbool = false;
                Wartextdusman.textbool = true;

                dusmanskiltext1.SetActive(false);
                dusmanskiltext2.SetActive(true);
                dusmanskiltext3.SetActive(false);
                dusmanskiltext4.SetActive(false);
                dusmanskiltext5.SetActive(false);

                break;
            case 3:

                Warbirdusmancan.dusmancan += 20;
                Warbiranakaraktercan.anacan -= 10;
                MusicSoundScript.hitbool = false;
                Wartextdusman.textbool = true;

                dusmanskiltext1.SetActive(false);
                dusmanskiltext2.SetActive(false);
                dusmanskiltext3.SetActive(true);
                dusmanskiltext4.SetActive(false);
                dusmanskiltext5.SetActive(false);

                break;
            case 4:

                Warbiranakaraktercan.anacan -= 10;
                MusicSoundScript.hitbool = false;
                Wartextdusman.textbool = true;

                dusmanskiltext1.SetActive(false);
                dusmanskiltext2.SetActive(false);
                dusmanskiltext3.SetActive(false);
                dusmanskiltext4.SetActive(true);
                dusmanskiltext5.SetActive(false);

                break;
            case 5:

                Warbiranakaraktercan.anacan -= 20;
                MusicSoundScript.hitbool = false;
                Wartextdusman.textbool = true;

                dusmanskiltext1.SetActive(false);
                dusmanskiltext2.SetActive(false);
                dusmanskiltext3.SetActive(false);
                dusmanskiltext4.SetActive(false);
                dusmanskiltext5.SetActive(true);

                savas = 0;

                break;
            default:

                break;
        }
    }

    IEnumerator SkilDusman() 
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
            randomdamage = Random.Range(0,35);
            Warbirdusmancan.dusmancan -= randomdamage;
            Wartextanakarakter.textboolea = true;

            anaskiltext1.SetActive(true);
            anaskiltext2.SetActive(false);
            anaskiltext3.SetActive(false);
            anaskiltext4kritik.SetActive(false);
            anaskiltext4miss.SetActive(false);
            MusicSoundScript.hitbool = false;
        }
    }  

    public void Skiliki()  
    {
        if (karakteratak == true)
        {
            karakteratak = false;            
            Warbiranakaraktercan.anacan += 20;
            Wartextanakarakter.textboolea = true;
            MusicSoundScript.healbool = false;
            anaskiltext1.SetActive(false);
            anaskiltext2.SetActive(true);
            anaskiltext3.SetActive(false);           
            anaskiltext4kritik.SetActive(false);
            anaskiltext4miss.SetActive(false);
        }
    }

    public void Skiluc() 
    {
        if (karakteratak == true)
        {
            karakteratak = false;
            Warbirdusmancan.dusmancan -= 20;
            Wartextanakarakter.textboolea = true;

            anaskiltext1.SetActive(false);
            anaskiltext2.SetActive(false);
            anaskiltext3.SetActive(true);
            anaskiltext4kritik.SetActive(false);
            anaskiltext4miss.SetActive(false);
            MusicSoundScript.hitbool = false;
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

            }           
        }
    }   
}
