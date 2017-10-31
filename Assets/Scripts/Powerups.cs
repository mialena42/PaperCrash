using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class Powerups : MonoBehaviour {

	virtual public void Activar(GameObject player)
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Activar(collision.gameObject);
            Destroy(this.gameObject);
        }
        if (collision.CompareTag("Muerte"))
        { 
            Destroy(this.gameObject);
        }
    }

}
