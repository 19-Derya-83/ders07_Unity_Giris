using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LifeCycle

{

    // Metodlar�n �al��ma s�ras�

    public class Player01 : MonoBehaviour
    {
        // Awake metodu atand���nda �nce "Awake" metodu �al���r, sonra "Start" metodu �al���r. "New" leme i�lemleri "Awake" in i�inde yap�l�r. Onun d���ndakiler "start" metodunda yap�l�r.
        // �lk �nce �al��mas�n� istedi�imiz fonksiyonlar� "Awake" metoduna yazar�z.(Start tan da �nce �al��mas�n� istedi�imiz fonksiyonlar�)
        // Oyun a��ld���nda bir kere �al���r.
        private void Awake() 
        {

            Debug.Log("Awake");

        }


        // Oyun a��l�r a��lmaz "Awake" metodundan sonra �al���r. E�er On Enable metodu tan�mlanm��sa "Start" metodu bundan sonra �al���r.
        // Oyundaki herhangi bir objeyi "Enable" ya da "Disable" yapt���m�zda her defas�nda �al���r.
        private void OnEnable()
        {

            Debug.Log("On Enable");

        }


        // De�er atama...v.b. i�lemler "Start" metodu i�inde yap�l�r.
        // Oyun a��ld���nda bir kere �al���r.
        private void Start() 
        {

            Debug.Log("Start");

        }



        // Update e benziyor, fix bir �ekilde �al���r. Defult olarak 0.02 sn ye bir �al���r.
        // Fizik i�lemleri yap�l�r, fizik i�lemlerinin fix olmas� gerekir. Her cihaz ayn� performansa sahip olmad��� i�in baz� i�lemleri fix leriz, bunu da fiz update ile yapar�z.
        private void FixedUpdate()
        {

            Debug.Log("Fixed Update");

        }



        // Cihaz�n veya bilgisayar�n her frame inde �al���r.
        private void Update()
        {

            Debug.Log("Update");

        }



        // "Late Update" metodu "Update" metodundan sonra �al���r.
        // Update" metodu gibi her frame de a����r, ancak frame in sonunda �al���r.
        private void LateUpdate()
        {

            Debug.Log("Late update");

        }




        // On enable �n tam tersidir.
        // 
        private void OnDisable()
        {

            Debug.Log("On Disable");

        }

    }

}
