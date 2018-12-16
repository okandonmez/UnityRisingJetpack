using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sawController : MonoBehaviour {
	// Use this for initialization
   
	void Start () {
        var objectPosition = transform.position;
        Debug.Log(objectPosition.x);
	}
	
	// Update is called once per frame
	void Update () {
        var objectPosition = transform.position;

        transform.position = objectPosition;

	}
}
