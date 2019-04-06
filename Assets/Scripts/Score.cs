using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour
{
	private float score =0.0f;
	private int dificultyLevel = 1;
	private int maxDificultyLevel = 10;
	private int scoreToNextLevel = 10;
	private bool isDead = false;
	public Text scoreText; 
    
    // Update is called once per frame
    void Update()
    {
		if(isDead)
			return;
		if(score >= scoreToNextLevel)
		{
			LevelUp();
		}
		score += Time.deltaTime * dificultyLevel;
		scoreText.text = ((int)score).ToString();
        
		//Increase the  speed of the player after ever 30 seconds
    }
	void LevelUp()
	{
		if(dificultyLevel == maxDificultyLevel)
			return;
		scoreToNextLevel *= 2;
		dificultyLevel++;
		GetComponent<PlayerMoter>().SetSpeed(dificultyLevel);
		Debug.Log(dificultyLevel);
	}
	public void OnDeath() {
	isDead = true;
	}
}
