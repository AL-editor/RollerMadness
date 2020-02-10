using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int healthPoints = 1;
    public int respawnHealthPoints = 1;
    public int numberOfLives= 1;
    public bool isAlive = true;
    public GameObject explosionPrefab ;

    public enum LiveGoneSitutations
    {
        DoNothingWhenDead,
        LoadLevelWhenDead
    }
    public LiveGoneSitutations OnLivesGone;
    public string loadToLevel;


}
