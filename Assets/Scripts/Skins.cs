using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skins : Powerups {

    Sprite color;

    public override void Activar(GameObject player)
    {
        player.GetComponent<SpriteRenderer>().sprite = color;
    }

    public void SetColor(Sprite colorParametro)
    {
        color = colorParametro;
    }
}
