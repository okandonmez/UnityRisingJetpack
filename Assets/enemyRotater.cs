using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyRotater : MonoBehaviour {
    
    bool isRotating = true;
    public int gidilecekYon;
    GameObject jetpack;
    Rigidbody2D rb;
	// Use this for initialization
	void Start () {
        jetpack = GameObject.FindWithTag("Player");
        rb = transform.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        var positionVector = transform.position;
        var jetpackPosition = jetpack.transform.position;
        if (positionVector.y - jetpackPosition.y < 9){
            Debug.Log("asagi git");
            positionVector.y -= (float)0.07;
            if (gidilecekYon == 1){
                positionVector.x += (float)0.07; 
            }
            if(gidilecekYon == 2){
                positionVector.x -= (float)0.07;
            }
            transform.position = positionVector;
        }

        transform.position = positionVector;
        if (isRotating) {
            var rotationVector = transform.rotation.eulerAngles;
            rotationVector.z += 20;
            transform.rotation = Quaternion.Euler(rotationVector);    
        }

	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
        if (collision.transform.tag == "Player") {
            isRotating = false;
        }
	}
}
