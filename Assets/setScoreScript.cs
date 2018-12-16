using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class setScoreScript : MonoBehaviour {

    int score;
    public Text text;

	void Start () {
        score = PlayerPrefs.GetInt("Score", 0);
        text.text = score.ToString();
       
	} 
	
	// Update is called once per frame
	void Update () {
		
	}
}
