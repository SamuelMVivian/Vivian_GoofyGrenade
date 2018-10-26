﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScr : MonoBehaviour {
    public Transform rightHand;
    public GameObject grenade;
    GameObject gInstance;
    public bool g;
	// Use this for initialization
	void Start () {
        g = false;
	}

	// Update is called once per frame
	void Update () {
		if (OVRInput.Get(OVRInput.Axis1D.SecondaryHandTrigger) != 0.0f && !g)
        {
         //Debug.Log("held!");
        gInstance = Instantiate(grenade, rightHand.position, Quaternion.identity);
          grenade.GetComponent<GrenadeScr>().playerObj = gameObject;
          g = true;
       }
       if(OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger)){
         gInstance.GetComponent<GrenadeScr>().Explode();
       }
	}
}