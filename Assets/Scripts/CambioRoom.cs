﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class CambioRoom : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown(KeyCode.R))
		{
			SceneManager.LoadScene("Mapa");
		}

	}
}
