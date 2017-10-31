using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CantidadDisparo : Powerups {

    public override void Activar(GameObject player)
    {
        player.GetComponent<AvioncitoMovimiento>().SetTresBalas(true);
    }
}
