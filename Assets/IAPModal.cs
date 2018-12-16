using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IAPModal : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void BuyNoAds(){
        IAPManager.Instance.BuyNoAds();
    }
}
