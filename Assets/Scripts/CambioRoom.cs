using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class CambioRoom : MonoBehaviour {
    public HighScore highscore;
    public Text score;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        score.text = ((int) highscore.GetHighScore()).ToString();

		if(Input.GetKeyDown(KeyCode.R))
		{
            highscore.ResetHighScore();
			SceneManager.LoadScene("Mapa");
		}

	}
}
