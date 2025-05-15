using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage=false;  
    [SerializeField] Color32 noPackageColor=new Color32(47,90,255,50);
    [SerializeField] Color32 hasPackageColor=new Color32(255,255,255,255);
    [SerializeField] float destroyDelay=0;

    SpriteRenderer spriteRenderer;
    void Start()
    {
        spriteRenderer=GetComponent<SpriteRenderer>();
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Ouch");
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag =="Package"&&!hasPackage) 
        {
            Debug.Log("Package picked up");
            hasPackage=true;
            spriteRenderer.color=hasPackageColor;  //paketin alındığı rengi sprite renderera ata
            Destroy(other.gameObject,destroyDelay);
        }
        else if(other.tag=="Customer"&&hasPackage)
        {
            Debug.Log("Packege delivered");
            hasPackage=false;  //paket teslim edildiğinde paketimiz olmayacak
            spriteRenderer.color=noPackageColor;
        }
    }
}
