using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {
    public HighScore highscore;
    Text textoScore;
	// Use this for initialization
	void Start () {
        textoScore = gameObject.GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        textoScore.text = ((int)highscore.GetHighScore()).ToString();
	}
}
