using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameBehavior : MonoBehaviour
{

    public String labelText = "Collect all 4 items and win your freedom!";
    public bool showWinScreen = false;
    public int maxItems = 4;
    private int _itemsCollected = 0;
    public bool showLossScreen = false;

    public int Items
    {
        get => _itemsCollected;
        set {
            _itemsCollected = value;
            Debug.LogFormat("Items: {0}", _itemsCollected);
            if (_itemsCollected >= maxItems)
            {
                ShowGameResultScreen("You've found all the items!",true,false,0f);
            }
            else
            {
                labelText = "Items found, only " + (maxItems - _itemsCollected) + " more to go!";
            }
        }
    }
    private int _playerHP = 10;
    public int HP
    {
        get => _playerHP;

        set {
            _playerHP = value;
            Debug.LogFormat("Lives: {0}", _playerHP);

            if (_playerHP <= 0)
            {
                ShowGameResultScreen("You want another life with that?",false,true,0f);
            }
            else
            {
                labelText = "Ouch... that's got hurt.";
            }
        }
        
    }

    void RestartLevel()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1.0f;
    }
    void OnGUI()
    {
        GUI.Box(new Rect(20, 20, 150, 25), "Player Health: " + _playerHP);
        GUI.Box(new Rect(20, 50, 150, 25), "Items Collected: " + _itemsCollected);
        GUI.Label(new Rect(Screen.width / 2 - 100, Screen.height - 50, 300, 50), labelText);

        if (showWinScreen)
        {
            if (GUI.Button(new Rect(Screen.width/2, Screen.height /2 - 50, 200, 100), "You Won!"))
            {
                RestartLevel();
            }
        }

        if (showLossScreen)
        {
            if (GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 50, 200, 100), "You Lose..."))
            {
                RestartLevel();
            }
        }
    }
    
    void ShowGameResultScreen(String labelText, bool showWinScreen, bool showLossScreen, float timeScale)
    {
        this.labelText = labelText;
        this.showWinScreen = showWinScreen;
        this.showLossScreen = showLossScreen;
        Time.timeScale = timeScale;
    }
    
    void Start()
    {
        
    }
    
    void Update()
    {
        
    }
}
