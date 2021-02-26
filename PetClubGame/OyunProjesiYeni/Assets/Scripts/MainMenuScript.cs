using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using DG.Tweening;

public class MainMenuScript : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject loadButton;
    public GameObject MainGame;
    public GameObject Settıngs;
    public GameObject GoingGame;
    public GameObject FirstCutScene;
    public GameObject CutScenes;
    public GameObject credits;
    public GameObject menu;
    public GameObject text1, next1;
    public int control;


    public static bool OyunSifirlayici = false;

    private void Update()
    {
        if (PlayerPrefs.HasKey("mainControl"))
        {
            loadButton.SetActive(true);
        }
        else
        {
            loadButton.SetActive(false);
        }
    }
    public void LoadGameButton()
    {
        MainMenu.SetActive(false);
        GoingGame.SetActive(false);
        MainGame.SetActive(true);
        menu.SetActive(true);
    }
    
    public void PlayButton()
    {
        menu.SetActive(false);
        GoingGame.SetActive(true);
    }
    public void BackPlayMainMenuButton()
    {
        menu.SetActive(true);
        credits.SetActive(false);
        Settıngs.SetActive(false);
        GoingGame.SetActive(false);
    }
    public void SettıngsButton()
    {
        menu.SetActive(false);
        Settıngs.SetActive(true);
        
    }
    public void Creditsbutton()
    {
        menu.SetActive(false);
        credits.SetActive(true);
    }
    public void BackMainMenuButton()
    {
        menu.SetActive(true);
        credits.SetActive(false);
        Settıngs.SetActive(false);
        GoingGame.SetActive(false);
    }
    public void QuitButton()
    {
        Application.Quit();
        Debug.Log("Exiting Now");
    }
    public void NewGameButton()
    {
        StartCoroutine(delay());
        Wartextanakarakter.textboolea = true;
        text1.SetActive(true);
        FirstCutScene.SetActive(true);
        MainMenu.SetActive(false);
        CutScenes.SetActive(true);
        OyunSifirlayici = true;
        GoingGame.SetActive(false);
        menu.SetActive(true);
        MusicSoundScript.cutscenem2 = false;
        PlayerPrefs.SetInt("mainControl", control);
    }

    public void zekaoyunu()
    {
        MainMenu.SetActive(false);
        CutScenes.SetActive(false);

    }
    IEnumerator delay()
    {

        yield return new WaitForSeconds(9);
        next1.SetActive(true);
    }
}
