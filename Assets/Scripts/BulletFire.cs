﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BulletFire : MonoBehaviour {

    public float fireTime = 0.2f;
         
	// Use this for initialization
	void Start () {
        InvokeRepeating("Fire", fireTime, fireTime);
	}
	
	// Update is called once per frame
	void Fire()
    {
        GameObject obj = Pooler.current.GetPooledObject();
        if (obj == null) return;
        obj.transform.position = transform.position;
        obj.transform.rotation = transform.rotation;
        obj.SetActive(true);
    }
}
