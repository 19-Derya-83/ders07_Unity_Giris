using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameObjectExamples

{

    public class GameObjectExample01 : MonoBehaviour
    {
        private BoxCollider _boxCollider;

        public Rigidbody _rigidBody;

        public Rigidbody[] rigitBodies;

        private SphereCollider _sphereCollider;

        private GameObjectExample02 _gameObjectExample02;

        public GameObject player03GameObject;

        private Player03 _player03;

        private void Start()
        {
            #region Game Object

            //Debug.Log("Name : " + gameObject.name);
            //Debug.Log("Layer : " + gameObject.layer);
            //Debug.Log("Static : " + gameObject.isStatic);
            //Debug.Log("Tag : " + gameObject.tag);

            #endregion Transform

            #region Transform

            // gameObject.transform.position => Uzun yazýmý

            //Debug.Log(" Position all : " + transform.position);
            //Debug.Log(" Position X : " + transform.position.x);
            //Debug.Log(" Position Y : " + transform.position.y);
            //Debug.Log(" Position Z : " + transform.position.z);

            //Debug.Log(" Raotation all : " + transform.localEulerAngles);
            //Debug.Log(" Raotation X : " + transform.localEulerAngles.x);
            //Debug.Log(" Raotation Y : " + transform.localEulerAngles.y);
            //Debug.Log(" Raotation Z : " + transform.localEulerAngles.z);

            //Debug.Log(" Scale all : " + transform.localScale);
            //Debug.Log(" Scale X : " + transform.localScale.x);
            //Debug.Log(" Scale Y : " + transform.localScale.y);
            //Debug.Log(" Scale Z : " + transform.localScale.z);

            #endregion

            #region Get Compenent

            ////Debug.Log(gameObject.GetComponent<BoxCollider>().isTrigger); => Uzun yazým

            //_boxCollider = GetComponent<BoxCollider>();

            ////Debug.Log(_boxCollider.isTrigger);    // Defaultta false geldiði için consolda false olarak okunur, deðer verilmediði zaman.

            //if (_boxCollider != null)
            //{

            //    _boxCollider.isTrigger = false;

            //    Debug.Log(_boxCollider.isTrigger);

            //}

            //_rigidBody = GetComponent<Rigidbody>();

            //_rigidBody.mass = 100;
            //_rigidBody.drag = 20;

            #endregion

            #region Get Compenent Children

            //_rigidBody =  GetComponentInChildren<Rigidbody>();

            //_rigidBody.mass = 100;


            //rigitBodies = GetComponentsInChildren<Rigidbody>();

            //foreach (var rigidbody01 in rigitBodies)
            //{

            //    rigidbody01.mass = 20;

            //}

            #endregion

            #region Get Compenent Parent

            //_sphereCollider = GetComponentInParent<SphereCollider>();

            //_sphereCollider.isTrigger = true;
            //_sphereCollider.radius = 5;

            //_gameObjectExample02 = GetComponentInParent<GameObjectExample02>();

            //_gameObjectExample02.name = "Player05";
            //_gameObjectExample02.power = 100;

            //Debug.Log(_gameObjectExample02.name);
            //Debug.Log(_gameObjectExample02.power);

            #endregion

            #region Game Object Find

            //player03GameObject = GameObject.Find("Player03");

            //player03GameObject = GameObject.FindGameObjectWithTag("Player");

            //Debug.Log( _player03GameObject.name);
            //Debug.Log( _player03GameObject.tag);
            //Debug.Log( _player03GameObject.layer);

            _player03 = player03GameObject.GetComponent<Player03>();
            

            Debug.Log(_player03.name);
            Debug.Log(_player03.health);

            _player03.TakeDamege();
            Debug.Log(_player03.health);

            #endregion

        }

    }

}
