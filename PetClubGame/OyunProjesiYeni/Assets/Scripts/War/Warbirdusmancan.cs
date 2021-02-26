using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Warbirdusmancan : MonoBehaviour
{
    public Slider staminabar;
    public static int dusmancan = 100;

    private void Update()
    {
        staminabar.value = dusmancan;
    }
}
