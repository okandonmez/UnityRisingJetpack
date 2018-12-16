using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballController : MonoBehaviour {

    bool isInteracted = false;
    GameObject jetpack;
	// Use this for initialization
	void Start () {
        jetpack = GameObject.FindWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
        var jetpackPosition = jetpack.transform.position;
        var ballPosition = transform.position;

        if (!isInteracted){
            
           if (ballPosition.y - jetpackPosition.y < 6){
                ballPosition.x += (float)0.07;
                ballPosition.y -= (float)0.07;
            }

        transform.position = ballPosition;
        }

      }

	private void OnCollisionEnter2D(Collision2D collision)
	{
        if(collision.transform.tag == "Player" || collision.transform.tag == "enemy"){
            isInteracted = true;
        }
	}
}
