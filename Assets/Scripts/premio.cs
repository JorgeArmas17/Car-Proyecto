using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class premio : MonoBehaviour
{
    int checkpoint = 0;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("mlagent"))
        {
            Invoke("MoverPosicion",0.01f);
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
            if (checkpoint == 0)
            {
                posicionPotencial = new Vector3(1.7f, 0.49f, 61f);
                checkpoint+=1;
                Debug.Log(posicionPotencial.ToString());
                Debug.Log(checkpoint.ToString());

            }
            else if(checkpoint == 1)
            {
                posicionPotencial = new Vector3(62.7f, 0.49f, 61f);
                checkpoint += 1;
                Debug.Log(posicionPotencial.ToString());
                Debug.Log(checkpoint.ToString());


            }
            else if (checkpoint == 2)
            {
                posicionPotencial = new Vector3(62.7f, 0.49f, -0.1f);
                checkpoint += 1;
                Debug.Log(posicionPotencial.ToString());
                Debug.Log(checkpoint.ToString());


            }
            else if(checkpoint == 3)
            {
                posicionPotencial = new Vector3(1.7f, 0.49f, -0.1f);
                checkpoint = 0;
                Debug.Log(posicionPotencial.ToString());
                Debug.Log(checkpoint.ToString());
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
