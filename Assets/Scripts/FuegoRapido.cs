using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AumentaDisparo : Powerups {

    int VelocidadDisparo;

    public override void Activar(GameObject player)
    {
        player.GetComponent<AvioncitoMovimiento>().SetContadorMax(VelocidadDisparo);
    }

    public void SetVelocidadDisparo(int parametro)
    {
        VelocidadDisparo = parametro;
    }

}
