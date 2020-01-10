﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DifficultyButtons : MonoBehaviour
{
    private Button button;
    private game_Manager gameManager;
    public int difficulty;
    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(SetDifficulty);
        gameManager = GameObject.Find("GameManager").GetComponent<game_Manager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetDifficulty() {
        Debug.Log(gameObject.name +" was clicked");
        gameManager.StartGame(difficulty);
    }
}
