using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
   [SerializeField] GameObject thingToFollow; //unitye referans veriyoruz
    void LateUpdate() // lateupdate yaparsak updatten bi  tık sonra kendi pozisyonunu ayarlar,daha yumuşak geçiş olur
    {
        transform.position=thingToFollow.transform.position + new Vector3(0,0,-10);//referans verdiğimiz objenin pozisyonunu ata //fakat 3 boyutta z vektörünü 0 alacağındna bir şey görünmeyecek o yüzden vektör 3den z eksenini ayarla

        
    }
}
