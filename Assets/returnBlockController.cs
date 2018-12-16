using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class returnBlockController : MonoBehaviour {
    GameObject jetpack;
    public int gidilecekYon;
	// Use this for initialization
	void Start () {
        jetpack = GameObject.FindWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
        var jetpackPosition = jetpack.transform.position;
        var objectPosition = transform.position;

        if (gidilecekYon == 0 && objectPosition.y - jetpackPosition.y < 5){
            objectPosition.x += (float)0.09f;
        }
        if(gidilecekYon == 1 && objectPosition.y - jetpackPosition.y < 5){
            objectPosition.x -= (float)0.09f;
        }

        transform.position = objectPosition; 
	}
}
