using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class attemptScriptController : MonoBehaviour {

    public Text txtAttempts;
    int counter;
	// Use this for initialization
	void Start () {
        counter = PlayerPrefs.GetInt("AttemptCount", 0);
        counter++;
        txtAttempts.text = counter.ToString();
        PlayerPrefs.SetInt("AttemptCount", counter);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
