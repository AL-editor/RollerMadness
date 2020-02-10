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
            playerHealth.healthPoints -= damageAmount;
            if (playerHealth.healthPoints <= 0 && playerHealth.OnLivesGone == Health.LiveGoneSitutations.LoadLevelWhenDead)
                ResetGame();
        }
    }

    private void ResetGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
