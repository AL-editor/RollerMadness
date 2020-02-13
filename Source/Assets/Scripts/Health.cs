using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    [SerializeField]private int healthPoints = 1;
    public int health
    {
        set
        {
            healthPoints = value;
            if (healthDisplay) healthDisplay.text = healthPoints.ToString();
        }
        get { return healthPoints; }
    }
    public int respawnHealthPoints = 1;
    public int numberOfLives= 1;
    public bool isAlive = true;
    public GameObject explosionPrefab ;
    public Text healthDisplay;

    public enum LiveGoneSitutations
    {
        DoNothingWhenDead,
        LoadLevelWhenDead
    }
    public LiveGoneSitutations OnLivesGone;
    public string loadToLevel;

    public void Explode()
    {
        Instantiate(explosionPrefab, transform.position, Quaternion.identity);
        gameObject.SetActive(false);
    }


}
