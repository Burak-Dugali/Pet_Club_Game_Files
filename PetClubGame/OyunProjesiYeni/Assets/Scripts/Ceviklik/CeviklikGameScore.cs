using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CeviklikGameScore : MonoBehaviour
{
    public static int cevclickdegeri = 0;
    public static Text cevclick;
    private void Start()
    {
        cevclick = GetComponent<Text>();
    }
    private void Update()
    {
        cevclick.text = "  " + cevclickdegeri;
    }
}

