using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money : MonoBehaviour
{
    public static int money,moneyforzeka;
    [SerializeField] Text moneytext , marketmoney ;
    // Update is called once per frame
    private void Start()
    {
        money = money+moneyforzeka;
        money=PlayerPrefs.GetInt("Money");
    }
    void Update()
    {
        PlayerPrefs.SetInt("Money", money);
        moneytext.text = money.ToString();
        marketmoney.text = money.ToString();
        if (MainMenuScript.OyunSifirlayici == true)
        {
            money = 0;
        }
    }
}
