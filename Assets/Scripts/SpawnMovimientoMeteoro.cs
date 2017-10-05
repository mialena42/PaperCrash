using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMovimientoMeteoro : MonoBehaviour {

	public int vida;
    public GameObject Spawn1;
    public GameObject Spawn2;
    public GameObject Spawn3;
    /*
    public GameObject Spawn4;
    public GameObject Spawn5;
    */
    public float direccionX;
    public float direccionY;
    Rigidbody2D CuerpoSpawn;
    public int NumeroPosicion;
	private int Maxvida;
    AvioncitoMovimiento player;


	// Use this for initialization
	void Start () {
        CuerpoSpawn = GetComponent<Rigidbody2D>();
        RandomeSpawn();
        AplicarFuerza();
		Maxvida = vida;
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<AvioncitoMovimiento>();
	}
	
	// Update is called once per frame
	void Update () {

		if (vida <= 0) 
		{
			CuerpoSpawn.velocity = new Vector3 (0, 0, 0);
			RandomeSpawn ();
			AplicarFuerza ();
			vida = Maxvida;
            player.SumarMonedas();

		}

		


	}

    // Ramdomizar spawn de meteoritos

    void RandomeSpawn()
    {
        float Randomizer = Random.Range(1f, 4.1f);

        if (Randomizer >= 1 && Randomizer < 2)
        {
            transform.position = Spawn1.transform.position;
            NumeroPosicion = 1;
        }

        if (Randomizer >= 2 && Randomizer <= 3)
        {
            transform.position = Spawn2.transform.position;
            NumeroPosicion = 2;
        }

        if(Randomizer >= 3.1f && Randomizer < 4)
        {
            transform.position = Spawn3.transform.position;
            NumeroPosicion = 3;
        }
        /*
        if (Randomizer >= 4.1f && Randomizer < 5)
        {
            //Debug.Log("aca");
            transform.position = Spawn4.transform.position;
            NumeroPosicion = 4;
        }
        if (Randomizer >= 5.1f && Randomizer < 6)
        {
            //Debug.Log("aca");
            transform.position = Spawn5.transform.position;
            NumeroPosicion = 5;
        }
        */


    }

    // Movimiento Meteoritos

    void AplicarFuerza()
    {
        if (NumeroPosicion == 1)
        {
            direccionY = 0;
            direccionX = -10;
            CuerpoSpawn.AddForce(new Vector3(direccionX, direccionY), ForceMode2D.Impulse);
        }

        if (NumeroPosicion == 2)
        {
            direccionY = -6;
            direccionX = -15;
            CuerpoSpawn.AddForce(new Vector3(direccionX, direccionY), ForceMode2D.Impulse);
        }

        if(NumeroPosicion == 3)
        {
            direccionY = 6;
            direccionX = -13;
            CuerpoSpawn.AddForce(new Vector3(direccionX, direccionY), ForceMode2D.Impulse);
        }
        /*
        if (NumeroPosicion == 4)
        {
            direccionY = 10;
            direccionX = 0;
            CuerpoSpawn.AddForce(new Vector3(direccionX, direccionY), ForceMode2D.Impulse);
        }
        if (NumeroPosicion == 5)
        {
            direccionY = -10;
            direccionX = 0;
            CuerpoSpawn.AddForce(new Vector3(direccionX, direccionY), ForceMode2D.Impulse);
        }
        */

    }

	// Reciclaje de meteoritos

     void OnTriggerEnter2D(Collider2D Pared)
    {
        if(Pared.gameObject.tag == "P")
        {
            CuerpoSpawn.velocity = new Vector3(0, 0, 0);
            RandomeSpawn();
            AplicarFuerza(); Debug.Log("RECICLAJE METEORITO");
        }

		if(Pared.gameObject.tag == "B")
			{
				vida = vida - 1;
			}
    }




}
