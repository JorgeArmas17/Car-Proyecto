using Mono.Cecil.Cil;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Copa : MonoBehaviour
{
    int checkpoint = 1;
    int vuelta = 1;
    public GameObject puntaje;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("mlagent"))
        {
            Invoke("MoverPosicion", 0.01f);
        }
    }
    private void MoverPosicion()
    {
        bool PosicionEncontrada = false;
        int intentos = 1;

        Vector3 posicionPotencial = Vector3.zero;
        while (!PosicionEncontrada || intentos > 0)
        {
            intentos--;
            switch (checkpoint)
            {
                case 1:
                    posicionPotencial = new Vector3(5f, 0.188f, 62f);
                    checkpoint += 1;
                    break;
                case 2:
                    posicionPotencial = new Vector3(-13f, 0.188f, 73f);
                    checkpoint += 1;
                    break; 
                case 3:
                    posicionPotencial = new Vector3(-52f, 0.188f, 73f);
                    checkpoint += 1;
                    break;
                case 4:
                    posicionPotencial = new Vector3(-73f, 0.188f, 88f);
                    checkpoint += 1;
                    break;
                case 5:
                    posicionPotencial = new Vector3(-73f, 0.188f, 118f);
                    checkpoint += 1;
                    break;
                case 6:
                    posicionPotencial = new Vector3(-50f, 0.188f, 133f);
                    checkpoint += 1;
                    break;
                case 7:
                    posicionPotencial = new Vector3(-25f, 0.188f, 112f);
                    checkpoint += 1;
                    break;
                case 8:
                    posicionPotencial = new Vector3(-25f, 2.7f, 98f);
                    checkpoint += 1;
                    break;
                case 9:
                    posicionPotencial = new Vector3(-25f, 5.7f, 73f);
                    checkpoint += 1;
                    break;
                case 10:
                    posicionPotencial = new Vector3(-25f, 0.188f, 29f);
                    checkpoint += 1;
                    break;
                case 11:
                    posicionPotencial = new Vector3(-25f, 0.188f, 5f);
                    checkpoint += 1;
                    break;
                case 12:
                    posicionPotencial = new Vector3(-45f, 0.188f, 0f);
                    checkpoint += 1;
                    break;
                case 13:
                    posicionPotencial = new Vector3(-66f, 0.188f, -7f);
                    checkpoint += 1;
                    break;
                case 14:
                    posicionPotencial = new Vector3(-74f, 0.188f, -35f);
                    checkpoint += 1;
                    break;
                case 15:
                    posicionPotencial = new Vector3(-53f, 0.188f, -51f);
                    checkpoint += 1;
                    break;
                case 16:
                    posicionPotencial = new Vector3(-23f, 0.188f, -51f);
                    checkpoint += 1;
                    break;
                case 17:
                    posicionPotencial = new Vector3(3f, 0.188f, -45f);
                    checkpoint += 1;
                    break;
                case 18:
                    posicionPotencial = new Vector3(5f, 2.8f, -11f);
                    checkpoint += 1;
                    break;
                case 19:
                    posicionPotencial = new Vector3(5f, 0.188f, 4f);
                    checkpoint = 1;
                    vuelta += 1;
                    break;
            }
            if(vuelta == 2)
            {
                Time.timeScale = 0f;
                puntaje.SetActive(true);
            }
            Collider[] colliders = Physics.OverlapSphere(posicionPotencial, 0.05f);
            if (colliders.Length == 0)
            {
                transform.position = posicionPotencial;
                PosicionEncontrada |= true;
            }
        }
    }

}
