using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

public class BannerAdController : MonoBehaviour
{
    private BannerView bannerView;
   
    void Start()
    {
        #if UNITY_ANDROID
                string appId = "ca-app-pub-2944024283496397~8073650813";
      
        #endif

            // Initialize the Google Mobile Ads SDK.
        MobileAds.Initialize(appId);
        RequestBanner();
    }

    void RequestBanner()
    {
        #if UNITY_ANDROID
                string adUnitId = "ca-app-pub-2944024283496397/5906915805";
        #endif

        // Create a 320x50 banner at the top of the screen.
        bannerView = new BannerView(adUnitId, AdSize.Banner, AdPosition.Bottom);

        AdRequest request = new AdRequest.Builder().Build();

        // Load the banner with the request.
        bannerView.LoadAd(request);
    }

  
}
