using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Warbiranakaraktercan : MonoBehaviour
{
    public Slider staminabar;
    public static int anacan = 100; 

    private void Update()
    {
        staminabar.value = anacan;       
    }
}
