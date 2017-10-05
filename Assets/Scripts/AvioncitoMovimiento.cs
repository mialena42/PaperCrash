using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class AvioncitoMovimiento : MonoBehaviour {

    public float velocidad = 0;
    Rigidbody2D rb;
    Rigidbody2D rb2;
    public GameObject bala;
    public GameObject Arma;
    GameObject Balatemp;
    private int contador = 0;
    static private int contadorMax=20;
    static private int monedas;
    public static int movespeed = 1;
    public Vector3 userDirection = Vector3.right;
    SpriteRenderer spr;
    static private bool tresBalas;
    private float tiempoTresBalas;

    // Use this for initialization
    void Start() {
        //contadorMax = 20;
        //monedas = 0;
        tiempoTresBalas = 6f;
        //tresBalas = false;
        rb = GetComponent<Rigidbody2D>();
        spr = GetComponent<SpriteRenderer>();
    }

    public bool ReInteractuarTresBalas()
    {
        if (tresBalas)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    public int GetMonedas()
    {
        return monedas;
    }

    public void SetContadorMax(int nuevoContadorMax)
    {
        contadorMax = nuevoContadorMax;
    }

    public void SetTresBalas (bool nuevotresBalas)
    {
        tresBalas = nuevotresBalas;
    }

    public void SumarMonedas()
    {
        monedas++;
    }

    public void RestarMonedas(int cantidad)
    {
        monedas = monedas - cantidad;
    }
	
	// Update is called once per frame
	void Update () {

        if (tresBalas == true)
        {
            tiempoTresBalas = tiempoTresBalas - Time.deltaTime;
        }

        if (tiempoTresBalas <= 0)
        {
            tresBalas = false;
            tiempoTresBalas = 6f;
        }

       //Movimiento Nave
        
		if (Input.GetKey(KeyCode.D))
        {
            
            rb.AddForce(new Vector3(0.005f, 0, 0), ForceMode2D.Impulse);
        }

        
		if (Input.GetKey(KeyCode.A))
        {
           
            rb.AddForce(new Vector3(-0.005f, 0, 0), ForceMode2D.Impulse);
        }
        
		if (Input.GetKeyDown(KeyCode.W))
        {
			
            rb.AddForce(new Vector3(0, 2, 0), ForceMode2D.Impulse);

        }
		        

		//Diagonales Movimiento Nave

        if ((Input.GetKey(KeyCode.D)) && (Input.GetKey(KeyCode.W)))
		{
		rb.velocity = new Vector3(velocidad = 2, velocidad = 2, 0);
		}

        if ((Input.GetKey(KeyCode.D)) && (Input.GetKey(KeyCode.S)))
		{
		rb.velocity = new Vector3(velocidad = 2, velocidad = -2, 0);
		}

        if ((Input.GetKey(KeyCode.A)) && (Input.GetKey(KeyCode.W)))
		{
		rb.velocity = new Vector3(velocidad = -2, velocidad = 2, 0);
		}

        if ((Input.GetKey(KeyCode.A)) && (Input.GetKey(KeyCode.S)))
        {
		rb.velocity = new Vector3(velocidad = -2, velocidad = -2, 0);
		}



		//Creacion y movimiento de la bala

		if (Input.GetKey(KeyCode.Space) )
        {
            contador = contador + 1;
           

        }

        if(contador == contadorMax)
        {
            if (tresBalas == false)
            { 
                Balatemp = Instantiate(bala, new Vector3(Arma.transform.position.x+1, Arma.transform.position.y), Quaternion.identity);
                rb2 = Balatemp.GetComponent<Rigidbody2D>();
                rb2.AddForce(new Vector3(10, 0, 0), ForceMode2D.Impulse);
                contador = 0;
            }else
            {
                Balatemp = Instantiate(bala, new Vector3(Arma.transform.position.x + 1, Arma.transform.position.y), Quaternion.identity);
                rb2 = Balatemp.GetComponent<Rigidbody2D>();
                rb2.AddForce(new Vector3(10, 0, 0), ForceMode2D.Impulse);
                Balatemp = Instantiate(bala, new Vector3(Arma.transform.position.x + 1, Arma.transform.position.y), Quaternion.identity);
                rb2 = Balatemp.GetComponent<Rigidbody2D>();
                rb2.AddForce(new Vector3(10, 5, 0), ForceMode2D.Impulse);
                Balatemp = Instantiate(bala, new Vector3(Arma.transform.position.x + 1, Arma.transform.position.y), Quaternion.identity);
                rb2 = Balatemp.GetComponent<Rigidbody2D>();
                rb2.AddForce(new Vector3(10, -5, 0), ForceMode2D.Impulse);
                contador = 0;
            }
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Menu");
        }
        

    }

    // Muerte del Avion

    private void OnTriggerEnter2D(Collider2D Otro)
    {
        if (Otro.gameObject.tag == "Muerte")
        {
            Destroy(this.gameObject);
			SceneManager.LoadScene ("perdites");

        }

        if(Otro.gameObject.tag == "M")
        {
            Destroy(this.gameObject);
            Debug.Log("MECHOCOUNMETEORITO");
			SceneManager.LoadScene ("perdites");
        }
    }

    

}

