using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

public class reklam : MonoBehaviour
{
    InterstitialAd interstitial;
    // Start is called before the first frame update
    void Start()
    {
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

    // Update is called once per frame
    void Update()
    {
        if (interstitial.IsLoaded())
        {
            interstitial.Show();
        }
    }
}
