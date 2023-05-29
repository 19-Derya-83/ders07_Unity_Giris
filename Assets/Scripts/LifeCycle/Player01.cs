using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LifeCycle

{

    // Metodlarýn çalýþma sýrasý

    public class Player01 : MonoBehaviour
    {
        // Awake metodu atandýðýnda önce "Awake" metodu çalýþýr, sonra "Start" metodu çalýþýr. "New" leme iþlemleri "Awake" in içinde yapýlýr. Onun dýþýndakiler "start" metodunda yapýlýr.
        // Ýlk önce çalýþmasýný istediðimiz fonksiyonlarý "Awake" metoduna yazarýz.(Start tan da önce çalýþmasýný istediðimiz fonksiyonlarý)
        // Oyun açýldýðýnda bir kere çalýþýr.
        private void Awake() 
        {

            Debug.Log("Awake");

        }


        // Oyun açýlýr açýlmaz "Awake" metodundan sonra çalýþýr. Eðer On Enable metodu tanýmlanmýþsa "Start" metodu bundan sonra çalýþýr.
        // Oyundaki herhangi bir objeyi "Enable" ya da "Disable" yaptýðýmýzda her defasýnda çalýþýr.
        private void OnEnable()
        {

            Debug.Log("On Enable");

        }


        // Deðer atama...v.b. iþlemler "Start" metodu içinde yapýlýr.
        // Oyun açýldýðýnda bir kere çalýþýr.
        private void Start() 
        {

            Debug.Log("Start");

        }



        // Update e benziyor, fix bir þekilde çalýþýr. Defult olarak 0.02 sn ye bir çalýþýr.
        // Fizik iþlemleri yapýlýr, fizik iþlemlerinin fix olmasý gerekir. Her cihaz ayný performansa sahip olmadýðý için bazý iþlemleri fix leriz, bunu da fiz update ile yaparýz.
        private void FixedUpdate()
        {

            Debug.Log("Fixed Update");

        }



        // Cihazýn veya bilgisayarýn her frame inde çalýþýr.
        private void Update()
        {

            Debug.Log("Update");

        }



        // "Late Update" metodu "Update" metodundan sonra çalýþýr.
        // Update" metodu gibi her frame de açýþýr, ancak frame in sonunda çalýþýr.
        private void LateUpdate()
        {

            Debug.Log("Late update");

        }




        // On enable ýn tam tersidir.
        // 
        private void OnDisable()
        {

            Debug.Log("On Disable");

        }

    }

}
