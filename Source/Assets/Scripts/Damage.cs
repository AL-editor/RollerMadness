using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Damage : MonoBehaviour
{
    public int damageAmount = 10;
    public bool damageOnTrigger = true;
    public bool damageOnCollision = false;
    public bool continiousDamage = false;
    public bool continiousTimeBet = false;
    public bool destroySelfOnImpact = false;
    public float delayBeforeDestroy = 0;
    public GameObject explosionPrefab;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<Health>())
        {
            Health playerHealth = other.gameObject.GetComponent<Health>();
            playerHealth.health -= damageAmount;
            if (playerHealth.health <= 0 && playerHealth.OnLivesGone == Health.LiveGoneSitutations.LoadLevelWhenDead)
                ResetGame();
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<Health>())
        {
            Health playerHealth = collision.gameObject.GetComponent<Health>();
            playerHealth.health -= damageAmount;
            if (playerHealth.health <= 0 )
                ResetGame();

            Explode();
        }
    }

    public void Explode()
    {
        Instantiate(explosionPrefab, transform.position, Quaternion.identity);
        gameObject.SetActive(false);
    }
    private void ResetGame()
    {
        GameManager.instance.OnPlayerDeath();
    }
}
