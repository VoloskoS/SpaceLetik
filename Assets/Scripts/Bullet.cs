using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

    public float speed = 5;
	
	// Update is called once per frame
	void Update () {
        transform.Translate(0, speed * Time.deltaTime, 0);
	}
}
