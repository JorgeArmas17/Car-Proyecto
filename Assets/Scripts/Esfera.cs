using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
public class Esfera : MonoBehaviour
{
    private static int puntos = 0;
    public Text impPuntos;    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "target")
        {
            puntos += 50;
            impPuntos.text = puntos.ToString();
        }
    }
}
