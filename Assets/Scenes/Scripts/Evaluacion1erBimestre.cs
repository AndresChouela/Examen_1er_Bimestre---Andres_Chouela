using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evaluacion1erBimestre : MonoBehaviour {
    public int unidadesflota;
    public int dias;
    public int diaslluvia;
    int recorrido;
    int recorridolluvia;
    int montototal;
    int cantidadlitros;
	// Use this for initialization
	void Start () {
		if(dias < 5 || diaslluvia < 0 || diaslluvia > dias)
        {
            Debug.Log("Error");
        }
        else
        {
            recorrido = (dias - diaslluvia) * 90;
            recorridolluvia = diaslluvia * 120;
            cantidadlitros = (recorrido + recorridolluvia) / 15;
            montototal = cantidadlitros * 130 * unidadesflota;
            Debug.Log("Una flota de " + unidadesflota + " unidades trabajando durante " + dias + " días implicará un gasto de " + montototal + " pesos en concepto de combustible");
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
