using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Treasure : MonoBehaviour
{
    public int value = 10;
    public GameObject explosionPrefab;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<Health>())
        {
            
        }
    }

    internal void Explode()
    {
        Debug.Log(1);
        Instantiate(explosionPrefab, transform.position, Quaternion.identity);
        gameObject.SetActive(false);

    }
}
