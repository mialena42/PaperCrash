using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clonacion : MonoBehaviour {

    public int NumeroInstanciasMeteoritoPequeño;
    public int NumeroInstanciasMeteoritoMediano;
    public int NumeroInstanciasMeteoritoGrande;
    public GameObject MeteoritoGrande;
    public GameObject MeteoritoMediano;
    public GameObject MeteoritoPequeño;
    private GameObject ClonPequeño;
    private GameObject ClonMediano;
    private GameObject ClonGrande;

    // Use this for initialization
    void Start() {

        Clonar();
        

    }

    // Update is called once per frame
    void Update() {

    }

    //Fabrica de Asteroides

    void Clonar()
    {
        Debug.Log("Clonacion");

        for (int i = 0; i <= NumeroInstanciasMeteoritoPequeño; i++)
        {
            ClonPequeño = Instantiate(MeteoritoPequeño, new Vector3(MeteoritoPequeño.transform.position.x + i, MeteoritoPequeño.transform.position.y), Quaternion.identity);
        }

        for (int j = 0; j <= NumeroInstanciasMeteoritoMediano; j++)
        {
            ClonMediano = Instantiate(MeteoritoMediano, new Vector3(MeteoritoMediano.transform.position.x + j, MeteoritoMediano.transform.position.y), Quaternion.identity);
        }

        for (int k = 0; k <= NumeroInstanciasMeteoritoGrande; k++)
        {
            ClonGrande = Instantiate(MeteoritoGrande, new Vector3(MeteoritoGrande.transform.position.x + k, MeteoritoGrande.transform.position.y), Quaternion.identity);
        }
    }
}
