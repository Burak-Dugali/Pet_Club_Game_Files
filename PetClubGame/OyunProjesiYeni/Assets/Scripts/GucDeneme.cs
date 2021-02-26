using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GucDeneme : MonoBehaviour
{
    public int maxhealth = 100;
    public static int currentHealth;
    public int health = 0;
    int randomnbr;
    
    public GucBarScript healthbar,healthbar2,healthbar3,healthbar4,healthbar5;
    public GameObject mekik1, mekik2;
    public static float timerr1 = 0f;
    int mekik=0;
    public GameObject clickerr;

    void Start()
    {
        currentHealth = health;
        healthbar.SetHealth(health);
        
    }

    void Update()
    {
        switchmekik();
        
        timerr1 -= Time.deltaTime;
        if (timerr1 <= 0)
        {
            TakeDamage(2);
            timerr1 = GucBarScript.hız;
        }

        if (currentHealth <= 0)
        {
            currentHealth = 0;
            healthbar.SetHealth(currentHealth);
        }
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthbar.SetHealth(currentHealth);
    }

    public void Tiklama()
    {
        currentHealth += 5;
        randomnbr = Random.Range(0, 100);
        if (randomnbr < 25)
        {
            Money.money++;
        }
        MusicSoundScript.guceffectbool = false;
        mekik++;    

    }

    public void switchmekik()
    {

        switch (mekik)
        {
            case 1:
                mekik1.SetActive(false);
                mekik2.SetActive(true);
                return;
            case 2:
                mekik1.SetActive(true);
                mekik2.SetActive(false);
                mekik = 0;
                return;

        }


    }
}
