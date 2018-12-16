using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocketController : MonoBehaviour {

    public int gidilecekYon;
    bool isInteracted = false;
    GameObject jetpack;
	// Use this for initialization
	void Start () {
        jetpack = GameObject.FindWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
        if(!isInteracted){
            var jetpackPosition = jetpack.transform.position;
            var objectPosition = transform.position;

            if (objectPosition.y - jetpackPosition.y < 5 && gidilecekYon == 1)
            {
                objectPosition.x += (float)0.2f;
            }

            if(objectPosition.y - jetpackPosition.y < 5 && gidilecekYon == 2){
                objectPosition.x -= (float)0.2f;
            }

            transform.position = objectPosition;
        }

	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
        if(collision.transform.tag == "Player"){
            isInteracted = true;
        }
	}
}
