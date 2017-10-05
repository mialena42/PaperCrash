using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fondos : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position -= Vector3.right * Time.deltaTime*5;
        if (transform.position.x <= -17.8f)
        {
            transform.position = new Vector2(18f,transform.position.y);
        }
	}
}
