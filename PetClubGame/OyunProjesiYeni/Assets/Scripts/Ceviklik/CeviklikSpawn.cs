using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CeviklikSpawn : MonoBehaviour
{
    
    float x,y;
    Vector2 pos;
    int randomnbr;
    
    void Start()
    {
        CeviklikOyun();
    }  
        public void CeviklikOyun(){
        Ceviklikgamescript.ucma++;
        x = Random.Range(-2,3);
        y = Random.Range(-3,5);
        pos = new Vector2(x,y);
        transform.position = pos;
        CeviklikGameScore.cevclickdegeri++;
        randomnbr = Random.Range(0, 100);
        if (randomnbr < 25)
        {
            Money.money++;
        }
    }
    public void cevikliksound()
    {
        MusicSoundScript.ceviklikeffectbool = false;
    }
   
}
