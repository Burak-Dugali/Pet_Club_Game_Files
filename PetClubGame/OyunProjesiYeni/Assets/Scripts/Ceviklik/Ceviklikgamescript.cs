using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening;
public class Ceviklikgamescript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject StarterBtn;
    public GameObject geridonuskapalı;
    public GameObject süre;
    public GameObject ceviklikoyunsonu;
    public GameObject ceviklikoyun;
    public GameObject puanbutton;
    public GameObject nostamina;

    [SerializeField] Text gerisayım;
    public Text AnapuanCeviklik;
    public Text AnapuanCeviklikfight, AnapuanCeviklikfight2, AnapuanCeviklikfight3, AnapuanCeviklikfight4, AnapuanCeviklikfight5;
    public Text bitisekranıpuan;

    public static bool isgamestarted;
    public static bool isgameearned;
    bool timercontroller = false;
    bool startcont = false;

    public int a = 1;
    public int b = 2;
    public int c = -1;
    int ceviklikprefsdegeri;

    public static int cevanaekran;
    public static float currenttime = 0f;

    float startingtime = 30f;
    float x, y;
    Vector2 pos;
    public GameObject kus1, kus2;
    public static int ucma = 0;
    public RectTransform ceviklikbitisRect;
    public RectTransform ceviklikgameRect;

    void Start()
    {
        isgamestarted = false;
        isgameearned = false;
        currenttime = startingtime;
        puanbutton.SetActive(false);
        cevanaekran = PlayerPrefs.GetInt("Ceviklikprefsdegeri");
    }
    void Update()
    {
        switchmekik();
        if (MainMenuScript.OyunSifirlayici == true)
        {
            cevanaekran = 0;         
        }
        PlayerPrefs.SetInt("Ceviklikprefsdegeri", cevanaekran);
        AnapuanCeviklikfight.text = cevanaekran.ToString();
        AnapuanCeviklikfight2.text = cevanaekran.ToString();
        AnapuanCeviklikfight3.text = cevanaekran.ToString();
        AnapuanCeviklikfight4.text = cevanaekran.ToString();
        AnapuanCeviklikfight5.text = cevanaekran.ToString();
        AnapuanCeviklik.text = cevanaekran.ToString();
        if (isgamestarted)
        {
            timercontroller = true;
            timer();
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
        if(startcont==false)
        {
            if (StaminaSystem.stamin <= 0)
            {
                StartCoroutine(Nostamina());
 
            }
            else
            {
                isgamestarted = true;
                isgameearned = true;
                StarterBtn.SetActive(false);
                süre.SetActive(true);
                puanbutton.SetActive(true);
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
                puanbutton.SetActive(false);
                geridonuskapalı.SetActive(true);
                ceviklikgameRect.DOAnchorPos(new Vector2(-1920, 0), 0.25f);
                isgamestarted = false;
                timercontroller = false;
                gerisayım.color = Color.black;
                ceviklikbitisRect.DOAnchorPos(new Vector2(0, 0), 0.25f);
                if (CeviklikGameScore.cevclickdegeri >= 30)
                {
                    cevanaekran = cevanaekran + 2;
                    bitisekranıpuan.text = b.ToString();
                }
                else if (CeviklikGameScore.cevclickdegeri >= 20)
                {
                    cevanaekran = cevanaekran + 1;
                    bitisekranıpuan.text = a.ToString();
                }
                else if (CeviklikGameScore.cevclickdegeri <= 10)
                {
                    cevanaekran = cevanaekran - 1;
                    bitisekranıpuan.text = c.ToString();
                }
            }
        }
    }
    public void switchmekik()
    {

        switch (ucma)
        {
            case 1:
                kus1.SetActive(false);
                kus2.SetActive(true);
                return;
            case 2:
                kus1.SetActive(true);
                kus2.SetActive(false);
                ucma = 0;
                return;
        }
    }
}
