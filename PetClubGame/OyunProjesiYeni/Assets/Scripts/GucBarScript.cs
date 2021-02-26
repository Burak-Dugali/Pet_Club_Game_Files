using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GucBarScript : MonoBehaviour
{  
    public Slider slider1;
    public static int say;
    public static float hız=0.35f;
    public void SetMaxHealth(int health)
    {
        slider1.maxValue = health;
        slider1.value = health;
    }
    
    public void SetHealth(int health)
    {
        slider1.value = health;
    }

    private void Update() {
        if(slider1.value==slider1.maxValue&&GucGameScript.Guclevel==say){
            GucGameScript.Guclevel++;
            say++;
            GucDeneme.currentHealth=0;
            hız-=0.05f;
        }

    }
}
