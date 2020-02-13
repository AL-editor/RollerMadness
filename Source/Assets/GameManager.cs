using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    internal static GameManager instance;

    public GameObject Player;
    public GameState gameState;
    public int score;
    public bool canBeatLevel;
    public int beatLevelScore;
    public Canvas mainCanvas;
    public Text mainScoreDisplay;
    public Canvas gameOverCanvas;
    public Text gameOverScoreDisplay;
    public AudioSource BackgroundMusic;
    public AudioClip gameOverSFX;
    public AudioClip beatLevelSFX;

    private void Awake()
    {
        instance = this;
    }
    public void OnPlayerDeath()
    {
        gameState = GameState.Death;
        if (BackgroundMusic)
            BackgroundMusic.Stop();
       
        Player.GetComponent<Health>().Explode();
        mainCanvas.gameObject.SetActive(false);
        GameOver();
    }
    public void GameOver()
    {
        gameState = GameState.GameOver;
        if (gameOverSFX)
        {
            BackgroundMusic.clip = gameOverSFX;
            BackgroundMusic.loop = false;
            BackgroundMusic.Play();
        }
        gameOverCanvas.gameObject.SetActive(true);
        gameOverScoreDisplay.text = Player.GetComponent<Pickup>().treasures.ToString();

    }


}
public enum GameState
{
    Playing,
    Death,
    GameOver,
    BeatLevel
}
