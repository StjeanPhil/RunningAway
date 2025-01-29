using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public GameState gameState;

    public static event Action<GameState> OnGameStateChange;

    // Start is called before the first frame update
    void Start()
    {
        UpdateGameState(GameState.MainMenu);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Awake()
    {
        instance = this;
    }

    public void UpdateGameState(GameState newGameState)
    {
        gameState = newGameState;

        switch (gameState)
        {
            case GameState.MainMenu:
                Debug.Log("Main Menu");
                break;
            case GameState.InGame:
                HandleInGame();
                Debug.Log("In Game");
                break;
            case GameState.GameOver:
                Debug.Log("Game Over");
                break;
            default:
                //Throw an error
                break;
        }

        OnGameStateChange?.Invoke(gameState);
    }

    public enum GameState
    {
        MainMenu,
        InGame,
        GameOver
    }

    public void HandleMainMenu()
    {
        // TODO
    }

    public void HandleInGame()
    {
        // TODO
    }

    public void HandleGameOver()
    {
        // TODO
    }
}
