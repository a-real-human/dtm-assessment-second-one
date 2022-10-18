using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
    //score
    private int score;
    //to display the score
    public TextMeshProUGUI scoreText;
    //detect when the items are collected
    public List<GameObject> collectables;
    // Start is called before the first frame update
    public int NumberOfItems;
    void Start()
    {
        score = 0;

    }
    //TO UPDATE SCORE
    public void UpdateScore(int scoreToAdd)
    {
        //increases the score
        score += scoreToAdd;
        scoreText.text = "you have collected: " + score + "out of:" +NumberOfItems;
    }
}

