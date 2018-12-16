using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toolScripts : MonoBehaviour {
    private Rigidbody2D rb;

	// Use this for initialization
	void Start () {
        rb = transform.GetComponent<Rigidbody2D>();

	}
	
	// Update is called once per frame
	void Update () {
        rb.velocity = new Vector2(0, -2);
	}
}
