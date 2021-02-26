using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class YemekScript : MonoBehaviour
{
    public static int yemekdegeri=50;
    public Text yemektxt;
    public GameObject normal, et, ot;
    void Start()
    {
        if(PlayerPrefs.HasKey("Yemekdegeri"))
        {
            yemekdegeri = PlayerPrefs.GetInt("Yemekdegeri");
        }
        else
        {
            yemekdegeri = 50;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (MainMenuScript.OyunSifirlayici == true)
        {
            yemekdegeri = 50;
            StaminaSystem.stamin = 100;
            MainMenuScript.OyunSifirlayici = false;
        }
        PlayerPrefs.SetInt("Yemekdegeri", yemekdegeri);
        if(yemekdegeri==50)
        {
            
            et.SetActive(false);
            ot.SetActive(false);
            normal.SetActive(true);
        }
        if(yemekdegeri>50)
        {
            et.SetActive(true);
            ot.SetActive(false);
            normal.SetActive(false);
        }
        if(yemekdegeri<50)
        {
            et.SetActive(false);
            ot.SetActive(true);
            normal.SetActive(false);
        }
    }
}
