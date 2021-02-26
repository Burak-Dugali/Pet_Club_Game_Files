using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddButton : MonoBehaviour
{
    [SerializeField]
    private Transform puzzlepanel;
    [SerializeField]
    private GameObject btn;

    private void Awake()
    {
        for(int i=0;i<12;i++)
        {
            GameObject button = Instantiate(btn);
            button.name = "" + i;
            button.transform.SetParent(puzzlepanel,false);
        }
    }
}
