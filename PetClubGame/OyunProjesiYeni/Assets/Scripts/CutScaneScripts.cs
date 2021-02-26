using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/// <summary>
/// CutScanelerde tüm next geçişleri ve diğer cutscane ile ilgili işlemler burada yapılmaktadır. /// Create By Emre ///
/// </summary>

public class CutScaneScripts : MonoBehaviour
{
    public GameObject CutSceneone;
    public GameObject CutScenetwo;
    public GameObject CutScenethree;
    public GameObject CutScenefour;
    public GameObject CutScenefive;
    public GameObject MainGame;
    public GameObject text1, text2, text3, text4, text5;
    public GameObject next1, next2, next3, next4, next5;


    public void NextCutScane()
    {
        StartCoroutine(delay2());
        text2.SetActive(true);
        Wartextanakarakter.textboolea = true;
        CutSceneone.SetActive(false);
        CutScenetwo.SetActive(true);
    }
    public void NextCutScane2()
    {
        StartCoroutine(delay3());
        text3.SetActive(true);
        Wartextanakarakter.textboolea = true;
        CutScenetwo.SetActive(false);
        CutScenethree.SetActive(true);
    }
    public void NextCutScane3()
    {

        StartCoroutine(delay4());
        text4.SetActive(true);
        Wartextanakarakter.textboolea = true;
        CutScenethree.SetActive(false);
        CutScenefour.SetActive(true);
    }
    public void NextCutScane4()
    {
        StartCoroutine(delay5());
        text5.SetActive(true);
        Wartextanakarakter.textboolea = true;
        CutScenefour.SetActive(false);
        CutScenefive.SetActive(true);
    }
    public void NextCutScane5()
    {
        CutScenefive.SetActive(false);
        MainGame.SetActive(true);
        MusicSoundScript.cutsceneM1 = false;
    }
    public void BackCutScene1()
    {
        CutSceneone.SetActive(true);
        CutScenetwo.SetActive(false);
    }
    public void BackCutScene2()
    {
        CutScenethree.SetActive(false);
        CutScenetwo.SetActive(true);
    }
    public void BackCutScene3()
    {
        CutScenefour.SetActive(false);
        CutScenethree.SetActive(true);
    }
    public void BackCutScene4()
    {
        CutScenefive.SetActive(false);
        CutScenefour.SetActive(true);
    }
   
    
    IEnumerator delay2()
    {

        yield return new WaitForSeconds(4);
        next2.SetActive(true);
    }
    IEnumerator delay3()

    {
        yield return new WaitForSeconds(9);
        next3.SetActive(true);
    }
    IEnumerator delay4()
    {

        yield return new WaitForSeconds(13);
        next4.SetActive(true);
    }
    IEnumerator delay5()
    {

        yield return new WaitForSeconds(16);
        next5.SetActive(true);
    }
}
