using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// 
/// </summary>
public class DayanıklılıkGameSkor : MonoBehaviour
{
    public static int clickdegeri = 0;
    public static Text click;
    private void Start()
    {
        click = GetComponent<Text>();
    }
    private void Update()
    {
        click.text = "  " + clickdegeri;
    }
}

