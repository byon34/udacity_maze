﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour 
{
    //Create a reference to the CoinPoofPrefab
    public GameObject coinPoof;
  
    public void OnCoinClicked() {
        // Instantiate the CoinPoof Prefab where this coin is located
        Object.Instantiate(coinPoof, transform.position, Quaternion.Euler(-990f, 0, 0));
        // Destroy this coin. Check the Unity documentation on how to use Destroy
        Destroy(gameObject);
    }

}
