using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
    //score
    private int score = 0;
    //to display the score
    public TextMeshProUGUI scoreText;
    //detect when the items are collected
    public List<GameObject> collectables;
    public int NumberOfItems;
    private bool Beginning = true;
    // Start is called before the first frame update


    void Start()
    {
        score = 0;
        if (Beginning == true)
        {
		//sets the score displayed to that
            scoreText.text = "you have collected: " + score + "  out of " + NumberOfItems;
		//stops this from repeating and wiping the score
            Beginning = false;
        }
    }
    //TO UPDATE SCORE
    public void UpdateScore(int scoreToAdd)
    {
        //increases the score
        score += scoreToAdd;
	//updates what score is displayed to the player
        scoreText.text = "you have collected: " + score + "  out of " + NumberOfItems;
    }
}

