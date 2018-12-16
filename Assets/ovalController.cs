using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ovalController : MonoBehaviour {

    GameObject jetpack;
	// Use this for initialization
	void Start () {
        jetpack = GameObject.FindWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
        var enemyPosition = transform.position;
        var jetpackPosition = jetpack.transform.position;

        if (enemyPosition.y - jetpackPosition.y < 10){
            enemyPosition.y -= (float)0.1; 
        }

        transform.position = enemyPosition;
	}
}
