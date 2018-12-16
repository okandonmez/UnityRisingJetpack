using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyController : MonoBehaviour {

    Rigidbody2D rb;
    bool isGoingDown = true;
	// Use this for initialization
	void Start () {
        rb = transform.GetComponent<Rigidbody2D>();
        rb.collisionDetectionMode = CollisionDetectionMode2D.Continuous;

	}
	
	// Update is called once per frame
	void Update () {
        if (isGoingDown == true){
            rb.velocity = new Vector2(0, -2);
        } 
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
        if (collision.transform.tag == "Player"){
            isGoingDown = false;
            rb.gravityScale = 0.5f;
        }
        if (collision.transform.tag == "enemy"){
            isGoingDown = false;
            rb.gravityScale = 0.5f;
        }

        if(collision.transform.tag == "jetpack"){
        }
	}

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
