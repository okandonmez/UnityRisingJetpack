using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class handSignController : MonoBehaviour {

    int isFirstTry;
    SpriteRenderer spriteHand;
	// Use this for initialization
	void Start () {
        spriteHand = transform.GetComponent<SpriteRenderer>();

        isFirstTry = PlayerPrefs.GetInt("isFirstTry", 1);
        if (isFirstTry == 1){
            spriteHand.sortingOrder = 11;
            PlayerPrefs.SetInt("isFirstTry", 0);
            StartCoroutine(waitSec());
        }
    }
	
    IEnumerator waitSec () {
        yield return new WaitForSeconds(4);

        spriteHand.sortingOrder = -5;
    }
	void Update () {
		
	}
}
