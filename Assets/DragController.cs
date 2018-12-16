using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragController : MonoBehaviour {

    Rigidbody2D rb;
    public float maxSpeed = 10f;//Replace with your max speed

	private void Start()
	{
        rb = transform.GetComponent<Rigidbody2D>();
	}


	private void OnMouseDrag()
	{
        Debug.Log("mouseDrag");   
        Vector2 mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 objectPosition = Camera.main.ScreenToWorldPoint(mousePosition);

        //Vector2 curPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        // transform.position = objectPosition;
        rb.MovePosition(objectPosition);
       // rb.AddForce(new Vector2(objectPosition.x - transform.position.x, objectPosition.y - transform.position.y));

    }

	private void OnCollisionEnter2D(Collision2D collision)
	{
      
	}

}
