using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using GoogleMobileAds.Api;

public class playerController : MonoBehaviour {
    private Rigidbody2D rb;
    public Text txtScore;
    InterstitialAd interstitial;

    bool isEnded = false;

    public GameObject jetpack, explosion;

    private SpriteRenderer spriteExplosion;
    int scoreTxt;

	void Start () {
        setAdProfile();
        Time.timeScale = 1f;
        scoreTxt = 0;
        rb = transform.GetComponent<Rigidbody2D>();
        Physics2D.IgnoreCollision(jetpack.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        spriteExplosion = explosion.GetComponent<SpriteRenderer>();
        spriteExplosion.sortingOrder = -5;
	}

	// Update is called once per frame
	void Update () {
        //rb.velocity = new Vector2(0, 2);
        /* int scoreTxt = (int)transform.position.y;
         scoreTxt += 2;
         scoreTxt *= 10; */
        scoreTxt++;
        txtScore.text = scoreTxt.ToString();

        if (isEnded){
            if (interstitial.IsLoaded())
            {
                interstitial.Show();
            }
        }
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
        if (collision.transform.tag == "enemy"){
            int score = (int)transform.position.y;
            PlayerPrefs.SetInt("Score", int.Parse(txtScore.text));
            Debug.Log(score * 10);
            spriteExplosion.sortingOrder = 11;
            StartCoroutine("waitSeconds");
        }

        if (collision.transform.tag == "Player"){
           
        }

	}

    IEnumerator waitSeconds()
    {
        isEnded = true;
        transform.GetComponent<Collider2D>().isTrigger = true;
        transform.localScale = new Vector3((float)0.01, (float)0.01, (float)0.01);
        Time.timeScale = 0.4f;
        yield return new WaitForSeconds((float)0.7);
        isEnded = true;
        SceneManager.LoadScene(2);
    }

    public void setAdProfile(){
        #if UNITY_ANDROID
        string appId = "ca-app-pub-2944024283496397~8073650813";
        #elif UNITY_IPHONE
                            string appId = "ca-app-pub-3940256099942544~1458002511";
        #else
                            string appId = "unexpected_platform";
        #endif

                // Initialize the Google Mobile Ads SDK.
                MobileAds.Initialize(appId);

        #if UNITY_ANDROID
                string adUnitId = "ca-app-pub-2944024283496397/9296476412";
        #elif UNITY_IPHONE
                        string adUnitId = "ca-app-pub-3940256099942544/4411468910";
        #else
                        string adUnitId = "unexpected_platform";
        #endif


        interstitial = new InterstitialAd(adUnitId);

        AdRequest request = new AdRequest.Builder().Build();
        // Load the interstitial with the request.
        interstitial.LoadAd(request);
    }

   
}
