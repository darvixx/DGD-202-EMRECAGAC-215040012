using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinCollect : MonoBehaviour
{
    private int Coin = 0;

    public TextMeshProUGUI Coins;


    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Coin")
        {
            Coin++;
            Coins.text = "Coin:" + Coin.ToString();
            Debug.Log(Coin);
            Destroy(other.gameObject);

        }
    }
}