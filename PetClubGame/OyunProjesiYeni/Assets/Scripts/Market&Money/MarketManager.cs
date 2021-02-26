using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MarketManager : MonoBehaviour
{
    //public GameObject staminpotion, food11, food22, food33;
    public static int stamninapot, food1, food2, food3;
    public GameObject Nomoney;
    IEnumerator Nostamina()
    {
        Nomoney.SetActive(true);
        yield return new WaitForSeconds(1f);
        Nomoney.SetActive(false);

    }
    public void Staminpott()
    {
        if(Money.money<200)
        {
            StartCoroutine(Nostamina());
        }
        else
        {
            Money.money -= 200;
            MusicSoundScript.marketbool = false;
            StaminaSystem.stamin += 20;
        }
    }
    public void Staminpott2()
    {
        if (Money.money < 400)
        {
            StartCoroutine(Nostamina());
        }
        else
        {
            Money.money -= 400;
            MusicSoundScript.marketbool = false;
            StaminaSystem.stamin += 40;
        }
    }
    public void Meatt()
    {
        if(Money.money<100)
        {
            StartCoroutine(Nostamina());
        }
        else
        {
            YemekScript.yemekdegeri = YemekScript.yemekdegeri + 10;
            MusicSoundScript.marketbool = false;
            Money.money -= 100;
            //Renk değişim değerleri girilicek
        }
    }
    public void Cabbageee()
    {
        if (Money.money < 100)
        {
            StartCoroutine(Nostamina());
        }
        else
        {
            YemekScript.yemekdegeri = YemekScript.yemekdegeri - 10;
            MusicSoundScript.marketbool = false;
            Money.money -= 100;
            //Renk değişim değerleri girilicek
        }
    }
    public void Carrot()
    {
        if (Money.money < 200)
        {
            StartCoroutine(Nostamina());
        }
        else
        {
            YemekScript.yemekdegeri = YemekScript.yemekdegeri - 30;
            Money.money -= 200;
            MusicSoundScript.marketbool = false;
        }
    }
    public void Meatt2()
    {
        if (Money.money < 200)
        {
            StartCoroutine(Nostamina());
        }
        else
        {
            YemekScript.yemekdegeri = YemekScript.yemekdegeri + 20;
            Money.money -= 200;
            MusicSoundScript.marketbool = false;
        }
    }
}
