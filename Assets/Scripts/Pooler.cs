﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Pooler : MonoBehaviour {

    public static Pooler current;
    public GameObject pooledObject;
    public int pooledAmount = 20;
    public bool willGrow = true;

    List<GameObject> pooledObjects;

    void Awake()
    {
        current = this;
    }

	// Use this for initialization
	void Start () {
        pooledObjects = new List<GameObject>();
        for (int i =0; i < pooledAmount; i++)
        {
            GameObject obj = (GameObject)Instantiate(pooledObject);
            obj.SetActive(false);
            pooledObjects.Add(obj);
        }	
	}

    public GameObject GetPooledObject()
    {
        for (int i = 0; i < pooledObjects.Count; i++)
        {
            if (!pooledObjects[i].activeInHierarchy)
            {
                return pooledObjects[i];
            }
        }

        if(willGrow)
        {
            GameObject obj = (GameObject)Instantiate(pooledObject);
            pooledObjects.Add(obj);
            return obj;
        }

        return null;
    }
}
