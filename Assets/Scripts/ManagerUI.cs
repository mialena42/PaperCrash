using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManagerUI : MonoBehaviour {

    bool enPausa;
    public Text textoMonedas;
    public GameObject Tienda;
    private AvioncitoMovimiento player;
    public Button botonChromaCyan;
    public Button botonAumentaDisparo;
    public Button botonTresBalas;
    public Sprite avioncitoCyan;
    bool once = false;

    // Use this for initialization
    void Start () {
        enPausa = false;
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<AvioncitoMovimiento>();
	}

    public void ChromaCyan()
    {
        if (player.GetMonedas()>=2) {
            player.gameObject.GetComponent<SpriteRenderer>().sprite=avioncitoCyan;
            player.RestarMonedas(2);
            botonChromaCyan.interactable = false;
        }
    }

    public void AumentaDisparo()
    {
        if (player.GetMonedas() >= 5)
        {
            player.SetContadorMax(10);
            player.RestarMonedas(5);
            botonAumentaDisparo.interactable = false;
        }
    }
    public void TresBalas()
    {
        if (player.GetMonedas() >= 10)
        {
            player.SetTresBalas(true);
            player.RestarMonedas(10);
            botonTresBalas.interactable = false;
        }
    }

    public void Pausa ()
    {
        
        if (!enPausa)
        {
            Debug.Log("Hola1");
            Time.timeScale = 0;
            enPausa = true;
            Tienda.SetActive(true);
        }
        else
        {
            Debug.Log("Hola2");
            Time.timeScale = 1;
            enPausa = false;
            Tienda.SetActive(false);
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (player.ReInteractuarTresBalas())
        {
            botonTresBalas.interactable = true;
        }
        else
        {
            botonTresBalas.interactable = false;
        }

        textoMonedas.text = player.GetMonedas().ToString();
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Pausa();
            once = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
       
        //Debug.Log("Crash");
        if (collision.CompareTag("Player")&&!once)
        {
            //Debug.Log("ExitoComparandoTag");
            once = true;
            Pausa();
            
        }
    }
}
