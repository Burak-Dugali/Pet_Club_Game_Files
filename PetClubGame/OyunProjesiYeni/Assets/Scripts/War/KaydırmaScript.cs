using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class KaydırmaScript : MonoBehaviour
{
    private Vector3 gidilecekYer;
    private Vector3 baslangıcNoktası = Vector3.zero;
    private Vector3 kameraPos = Vector3.zero;
    float kaydırmaHız = .003f;
    float maxy = 40f, miny = 0;
    [SerializeField]
    private Transform targetToFollow;
    void Update()
    {
        transform.position = new Vector3(0, Mathf.Clamp(targetToFollow.position.y, miny, maxy), transform.position.z);
    }
    private void FixedUpdate()
    {
        if (Input.GetMouseButton(0))
        {
            if (baslangıcNoktası == Vector3.zero)
            {
                baslangıcNoktası = Input.mousePosition;
                kameraPos = transform.position;
            }
            gidilecekYer = Input.mousePosition;
        }
        if (!Input.GetMouseButton(0))
        {
            baslangıcNoktası = Vector3.zero;
            return;
        }
        transform.position = new Vector3(0, kameraPos.y + ((baslangıcNoktası.y - gidilecekYer.y) * kaydırmaHız), -10);
    }
}
