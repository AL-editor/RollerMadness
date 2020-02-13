using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pickup : MonoBehaviour
{
    public float speed;
    public int countToWin = 12;
    public int treasureToWin = 20;
    public Text countText;
    public Text treasureText;
    public Text winText;
    [SerializeField]internal int treasures = 0;
    private Rigidbody rb;
    private int count;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            if (other.gameObject.GetComponent<Treasure>())
            {
                Treasure coin = other.gameObject.GetComponent<Treasure>();
                treasures += coin.value;
                coin.Explode();
                SetTreasureText();
            }
            count = count + 1;
            SetCountText();

        }
    }

    private void SetTreasureText()
    {
        if (treasureText) countText.text = "Treasures: " + treasures.ToString();

        if (treasures >= treasureToWin)
        {
            if (winText) winText.text = "You Win!";
        }
    }

    void SetCountText()
    {
        if(countText) countText.text = "Count: " + count.ToString();

        if (count >= countToWin)
        {
            if(winText) winText.text = "You Win!";
        }
    }
}
