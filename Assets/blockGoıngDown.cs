using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockGoıngDown : MonoBehaviour {

    GameObject jetpack;
	// Use this for initialization
	void Start () {
        jetpack = GameObject.FindWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
        var jetpackPosition = jetpack.transform.position;
        var objectPosition = transform.position;

        if(objectPosition.y - jetpackPosition.y < 5){
            Destroy(gameObject);
        }
	}
}
