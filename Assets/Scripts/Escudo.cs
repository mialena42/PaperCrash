using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escudo : Powerups {

    float tiempo=5;
    bool activo=false;
    GameObject plantillaEscudo;

    public void SetPlantillaEscudo(GameObject parametro)
    {
        plantillaEscudo = parametro;
    
    }

    public override void Activar(GameObject player)
    {
        Instantiate(plantillaEscudo, player.transform);
    }


    // Use this for initialization
    void Start () {
        activo = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (activo)
        {
            tiempo -= Time.deltaTime;
        
        }
        if (tiempo <= 0)
        {
            activo = false;
            tiempo = 0;
            Destroy(gameObject);
        }
	}
}
