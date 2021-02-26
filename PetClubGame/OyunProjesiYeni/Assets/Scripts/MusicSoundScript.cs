using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class MusicSoundScript : MonoBehaviour
{
    public AudioSource cutscenesrc,warmusicsrc,roadmapsrc,gucsrc,cevikliksrc,zekasrc,maingamesrc;
    public AudioSource fightsrc, cardflipsrc, ceviklikeffectsrc, guceffectsrc, marketsrc,hitsrc,healsrc;
    public AudioMixer mixer;
    public Slider masterSld;
    public static bool cutsceneM1 = true, cutscenem2 = true, warbool = true, warbool2 = true, roadmapstart = true, roadmapstop = true, maingamestart = true, maingamestop = true;
    public static bool ceviklikstart = true, ceviklikstop = true, zekastart = true, zekastop = true, gucstart = true, gucstop = true;
    public static bool fightbool = true,cardflipbool=true,ceviklikeffectbool=true,guceffectbool=true,marketbool=true;
    public static bool hitbool = true,healbool=true;
    private float control;
    void Start()
    {
        masterSld.value = PlayerPrefs.GetFloat("MasterVol");
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetFloat("MasterVol", masterSld.value);
        if(PlayerPrefs.HasKey("Control"))
        {
            PlayerPrefs.SetFloat("MasterVol", masterSld.value);
        }
        else
        {
            PlayerPrefs.SetFloat("MasterVol", masterSld.value = 1);
            PlayerPrefs.SetFloat("Control", control);
        }

        CutSceneMusic();
        warmusic();
        Roadmapmusic();
        FightSound();
        zekamusic();
        ceviklikmusic();
        gucmusic();
        maingamemusic();
        cardflipsound();
        cevikliksound();
        gucsound();
        marketsound();
        hitsound();
        healsound();
    }
    public void SetMasterLevel(float sliderValue)
    {
        mixer.SetFloat("MasterVolume", Mathf.Log10(sliderValue) * 20);
    }
    public void healsound()
    {
        if(healbool==false)
        {
            healsrc.Play();
            healbool = true;
        }
    }
    public void hitsound()
    {
        if(hitbool==false)
        {
            hitsrc.Play();
            hitbool = true;
        }
    }
    public void marketsound()
    {
        if(marketbool==false)
        {
            marketsrc.Play();
            marketbool = true;
        }
    }
    public void CutSceneMusic()
    {
        if(cutsceneM1==false)
        {
            cutscenesrc.Stop();
            cutsceneM1 = true;
        }
        if(cutscenem2==false)
        {
            cutscenesrc.Play();
            cutscenem2 = true;
        }
    }
    public void maingamemusic()
    {
        if(maingamestart==false)
        {
            maingamesrc.Play();
            maingamestart = true;
        }
        if(maingamestop==false)
        {
            maingamesrc.Stop();
            maingamestop = true;
        }
    }
    public void warmusic()
    {
        if(warbool==false)
        {
            warmusicsrc.Play();
            warbool = true;
        }
        if(warbool2==false)
        {
            warmusicsrc.Stop();
            warbool2 = true;
        }
    }
    public void Roadmapmusic()
    {
        if(roadmapstart==false)
        {
            roadmapsrc.Play();
            roadmapstart = true;
        }
        if(roadmapstop==false)
        {
            roadmapsrc.Stop();
            roadmapstop = true;
        }
    }
    public void FightSound()
    {
        if(fightbool==false)
        {
            fightsrc.Play();
            fightbool = true;
        }
    }
    public void zekamusic()
    {
        if (zekastart == false)
        {
            zekasrc.Play();
            zekastart = true;
        }
        if (zekastop == false)
        {
            zekasrc.Stop();
            zekastop = true;
        }
    }
    public void ceviklikmusic()
    {
        if (ceviklikstart == false)
        {
            cevikliksrc.Play();
            ceviklikstart = true;
        }
        if (ceviklikstop == false)
        {
            cevikliksrc.Stop();
            ceviklikstop = true;
        }
    }
    public void gucmusic()
    {
        if (gucstart == false)
        {
            gucsrc.Play();
            gucstart = true;
        }
        if (gucstop == false)
        {
            gucsrc.Stop();
            gucstop = true;
        }
    }
    public void cardflipsound()
    {
        if(cardflipbool==false)
        {
            cardflipsrc.Play();
            cardflipbool = true;
        }
    }
    public void cevikliksound()
    {
        if(ceviklikeffectbool==false)
        {
            ceviklikeffectsrc.Play();
            ceviklikeffectbool = true;
        }
    }
    public void gucsound()
    {
        if(guceffectbool==false)
        {
            guceffectsrc.Play();
            guceffectbool = true;
        }
    }

}
