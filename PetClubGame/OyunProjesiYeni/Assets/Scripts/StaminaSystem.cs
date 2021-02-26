using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StaminaSystem : MonoBehaviour
{
    public Slider staminabar;
    public static int stamin=100;
    public static float stamincurrenttime;
   
    float startingtime=180f;
    int control;
    /// <summary>
    /// //// bura ileride kayıtta tutulacak
    /// </summary>

    private void Start() {
        stamincurrenttime=startingtime;
        stamin = PlayerPrefs.GetInt("Stamina");
    }

    private void Update()
    {
        PlayerPrefs.SetInt("Stamina", stamin);
        if (PlayerPrefs.HasKey("Control"))
        {
            PlayerPrefs.SetInt("Stamina", stamin);
        }
        else
        {
            PlayerPrefs.SetInt("Stamina", stamin = 100);
            PlayerPrefs.SetInt("Control", control);
        }
        staminabar.value = stamin;
        if(stamin<100)
        {
                timer();  
        }

        if(stamin>100)
        {
            stamin = 100;
        }
 
    }
    
    public void timer()
    {
        stamincurrenttime -= 1 * Time.deltaTime*0.5f;
       
        if (stamincurrenttime<=0&&stamin!=100)
        {
            stamin=stamin+10;
            stamincurrenttime=startingtime;
        }
    }


    
}
