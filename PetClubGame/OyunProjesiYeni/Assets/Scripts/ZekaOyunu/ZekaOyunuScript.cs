using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening;
public class ZekaOyunuScript : MonoBehaviour
{
    public GameObject StarterBtn;
    public GameObject geridonuskapalı;
    public GameObject StartPanel;
    public GameObject cardsss;
    public GameObject finishscreen;
    public GameObject sure;
    public GameObject nostamina;

    public RectTransform ZekaOyunEkranı,ZekaOyunSonu;

    [SerializeField]
    private Sprite bgImage;

    public Sprite[] puzzles;

    [SerializeField] Text gerisayım;
    public Text bitisekranıtoanapuan;
    public Text bitisekranıskor;
    public Text startbuttontxt, nostamintxt,puankazandintxt;

    public List<Button> btns = new List<Button>();

    public List<Sprite> gamePuzzles = new List<Sprite>();

    public static float currenttime = 0f;
    float startingtime = 30f;

    public bool firstGuess, secondGuess;
    public static bool isgamestarted;
    public static bool isgameearned;
    bool timercontroller = false;
    bool startcont = false;

    public static int PrefsDegeri;
    public static int zekaanapuan;

    private int countGuesses;
    private int countCorrectGuesses;
    private int gameGuesses;
    private int firstGuessIndex, SecondGuessIndex;

    int a = 1;
    int b = 2;
    int c = -1;


    private string firstGuessPuzzle, secondGuessPuzzle;
    void Start()
    {
        isgamestarted = false;
        isgameearned = false;
        currenttime = startingtime;

        gameGuesses = gamePuzzles.Count / 2;
    }

    void Getbuttons()
    {
        GameObject[] objects = GameObject.FindGameObjectsWithTag("PuzzleButton");

        for(int i =0;i<objects.Length;i++)
        {
            btns.Add(objects[i].GetComponent<Button>());
            btns[i].image.sprite = bgImage;
        }
    }

    public void geridonus()
    {
        SceneManager.LoadScene("MainGame");
        MusicSoundScript.zekastop = false;
        MusicSoundScript.maingamestart = false;
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

    public void startBTN()
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
                StaminaSystem.stamin -= 10;
                StarterBtn.SetActive(false);
                cardsss.SetActive(true);
                geridonuskapalı.SetActive(false);
                StartPanel.SetActive(false);
                Getbuttons();
                AddListeners();
                AddGamePuzzles();
                Shuffle(gamePuzzles);
                Money.money =Money.money+ 30;
                PrefsDegeri = 0;
            }
        }
        

    }
    void AddGamePuzzles()
    {
        int looper = btns.Count;
        int index = 0;
        for(int i =0;i<looper;i++)
        {
            if(index==looper/2)
            {
                index = 0;
            }
            gamePuzzles.Add(puzzles[index]);
            index++;
        }
    }
    void AddListeners()
    {
        foreach(Button btn in btns)
        {
            btn.onClick.AddListener( ()=>PickAPuzzle() );

        }
    }

    public void PickAPuzzle()
    {
        string name = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name;
        if (!firstGuess)
        {
            firstGuess = true;
            firstGuessIndex = int.Parse(UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name);
            firstGuessPuzzle = gamePuzzles[firstGuessIndex].name;
            btns[firstGuessIndex].image.sprite = gamePuzzles[firstGuessIndex];
            btns[firstGuessIndex].interactable = false;
            MusicSoundScript.cardflipbool = false;
        }
        else if(!secondGuess)
        {
            secondGuess = true;
            SecondGuessIndex = int.Parse(UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name);
            secondGuessPuzzle=gamePuzzles[SecondGuessIndex].name;
            btns[SecondGuessIndex].image.sprite = gamePuzzles[SecondGuessIndex];
            StartCoroutine(CheckIfThePuzzlesMatch());
            btns[firstGuessIndex].interactable = false;
            MusicSoundScript.cardflipbool = false;
        }

    }
    IEnumerator CheckIfThePuzzlesMatch()
    {
        if (firstGuessPuzzle == secondGuessPuzzle)
        {
            yield return new WaitForSeconds(.5f);
            btns[firstGuessIndex].interactable = false;
            btns[SecondGuessIndex].interactable = false;

            btns[firstGuessIndex].image.color = new Color(0,0,0,0);
            btns[SecondGuessIndex].image.color = new Color(0,0,0,0);

            CheckIfTheGameIsFinished();
        }
        else
        {
            yield return new WaitForSeconds(.5f);
            btns[firstGuessIndex].image.sprite = bgImage;
            btns[firstGuessIndex].interactable = btns[SecondGuessIndex].interactable = true;
            btns[SecondGuessIndex].image.sprite = bgImage;
        }
        yield return new WaitForSeconds(.2f);
        firstGuess = secondGuess = false;
    }

    void CheckIfTheGameIsFinished()
    {
        countCorrectGuesses++;
    }

    void Shuffle(List<Sprite>list )
    {
        for (int i = 0;i<list.Count;i++)
        {
            Sprite temp = list[i];
            int randomIndex = Random.Range(0, list.Count);
            list[i] = list[randomIndex];
            list[randomIndex] = temp;
        }
    }

    void Update()
    {
        if(LanguageManager.dil==1)
        {
            nostamintxt.text = "No Stamina";
            startbuttontxt.text = "START";
            puankazandintxt.text = "Points " +
                "Earned";
        }
        else
        {
            nostamintxt.text = "Stamina Yok";
            startbuttontxt.text = "BAŞLA";
            puankazandintxt.text = "Puan " +
                "Kazandin";
        }
        if (isgamestarted)
        {
            timercontroller = true;
            timer();
        }
        if(countCorrectGuesses==6)
        {
            currenttime = 0;
        }
    }
    
    public void timer()
    {
        if (timercontroller == true)
        {

            currenttime -= 1 * Time.deltaTime;
            gerisayım.text = currenttime.ToString("0");
            if (currenttime < 6)
            {
                gerisayım.color = Color.red;
            }
            if (currenttime <= 0)
            {
                finishscreen.SetActive(true);
                geridonuskapalı.SetActive(true);
                ZekaOyunSonu.DOAnchorPos(new Vector2(0, 0), 0.25f);
                ZekaOyunEkranı.DOAnchorPos(new Vector2(-1920, 0), 0.25f);
                cardsss.SetActive(false);
                isgamestarted = false;
                timercontroller = false;
                gerisayım.color = Color.black;
                sure.SetActive(false);
                if (countCorrectGuesses >= 4)
                {
                    zekaanapuan =  2;
                    bitisekranıtoanapuan.text = b.ToString();
                }
                else if (countCorrectGuesses > 2)
                {
                    zekaanapuan =  1;
                    bitisekranıtoanapuan.text = a.ToString();
                }
                else if (countCorrectGuesses <= 2)
                {
                    zekaanapuan =  1;
                    bitisekranıtoanapuan.text = c.ToString();
                }
                PrefsDegeri = zekaanapuan;
                bitisekranıskor.text = countCorrectGuesses.ToString();
                
            }
        }
    }
}
