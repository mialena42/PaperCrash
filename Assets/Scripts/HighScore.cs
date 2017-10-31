using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HighScore : MonoBehaviour {
    static float highScore;
	// Use this for initialization
	void Start () {
        if (SceneManager.GetActiveScene().name.Equals("Menu"))
        {
            // Si la escena actual es el menu reinica el score
            highScore = 0;
        }
	}

    public void ResetHighScore()
    {
        highScore = 0;
    }

    public float GetHighScore()
    {
        return highScore;
    }
	
	// Update is called once per frame
	void Update () {
        if (SceneManager.GetActiveScene().name.Equals("Mapa"))
        {
            highScore += Time.deltaTime;
        }
	}
}
