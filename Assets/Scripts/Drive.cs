using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drive : MonoBehaviour
{
    [SerializeField]float steerSpeed=1f;
    [SerializeField]float moveSpeed=30f;
    [SerializeField]float boostSpeed=40f;
    [SerializeField]float slowSpeed=20f;

    void Start()
    {

    }

    void Update()
    {
        float steerAmount=Input.GetAxis("Horizontal")*steerSpeed*Time.deltaTime; //horizontaldaki inputları steerAmounta ata //değişkeni updatein içine tanımlamamızın nedeni her framede çalışmasını istememiz
        float moveAmount=Input.GetAxis("Vertical")*moveSpeed*Time.deltaTime;
         transform.Rotate(0, 0, -steerAmount);
         transform.Translate(0,moveAmount,0);  
      }
      void OnCollisionEnter2D(Collision2D other)
         {
            moveSpeed=slowSpeed;
         }
         void OnTriggerEnter2D(Collider2D other)
         {
            if(other.tag=="Boost")
            {
                
                moveSpeed=boostSpeed;
            }
    }
}
