using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// © 2017 TheFlyingKeyboard and released under MIT License
// theflyingkeyboard.net
public class DragAndDropNew : MonoBehaviour
{
    Rigidbody2D rb;
    // Use this for initialization
    void Start()
    {
        rb = transform.GetComponent<Rigidbody2D>();
        rb.AddForce(new Vector2(0, -1000));
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}