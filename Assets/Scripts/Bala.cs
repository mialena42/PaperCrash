using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour {

      

  


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
       

    }


    // Muerte de la Bala

    private void OnTriggerEnter2D(Collider2D Pared)
    {
        if(Pared.gameObject.tag == "R")
        {
            Destroy(this.gameObject);
        }
    }



    
}

