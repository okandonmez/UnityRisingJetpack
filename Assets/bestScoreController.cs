using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bestScoreController : MonoBehaviour {
    public Text bestScoreText;
    public GameObject newBestTitle;

    int score;
    int bestScore;
	// Use this for initialization
	void Start () {
        newBestTitle = GameObject.FindWithTag("newbest");
        var material = newBestTitle.GetComponent<SpriteRenderer>();
        material.color = new Color(194, 194, 194, 0);

        bestScore = PlayerPrefs.GetInt("BestScore", 0);
        score = PlayerPrefs.GetInt("Score", 0);

        if (score > bestScore){
            Debug.Log("best score");
            PlayerPrefs.SetInt("BestScore", score);
            bestScoreText.text = bestScore.ToString();
            material.color = new Color(194, 194, 194, 255);
        }
        else{
            bestScoreText.text = bestScore.ToString();
        }

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
