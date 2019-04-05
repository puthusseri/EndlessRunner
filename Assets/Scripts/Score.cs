using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour
{
	private float score =0.0f;
	
	public Text scoreText; 
    // Start is called before the first frame update
    void Start()
    {
		//scoreText = 0;     
    }

    // Update is called once per frame
    void Update()
    {
		score += Time.deltaTime;
		scoreText.text = ((int)score).ToString();
        
		//Increase the  speed of the player after ever 30 seconds
    }
}
