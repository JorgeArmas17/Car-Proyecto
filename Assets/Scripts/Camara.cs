using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{
    public GameObject objetoAseguir;
    private float alturaDeLaCamara =  2;
    private float velocidadDeSeguimiento = 10;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 posicionObjetivo = objetoAseguir.transform.position;
        posicionObjetivo.y += alturaDeLaCamara;
        transform.position = Vector3.Lerp(transform.position, posicionObjetivo, velocidadDeSeguimiento * Time.deltaTime);
    }
}
