using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Wartextanakarakter : MonoBehaviour
{
    public float delay = 0.1f;
    public string fulltext;
    private string currenttext = "";
    public static bool textboolea = false;


    private void Update()
    {

        if (textboolea == true)
        {
            StartCoroutine(Showtext());
            textboolea = false;
        }
    }
    IEnumerator Showtext()
    {
        for (int i = 0; i < fulltext.Length; i++)
        {
            currenttext = fulltext.Substring(0, i);
            this.GetComponent<Text>().text = currenttext;
            yield return new WaitForSeconds(delay);
        }
    }
}
