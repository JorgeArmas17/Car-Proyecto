using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.Services.Core.Environments;

public class Puntaje : MonoBehaviour
{
    public Servidor servidor;

    public DBUsuario usuario;
    public Text impPuntos;

    public void RegistroPuntaje()
    {
        StartCoroutine(Registrar());
    }

    IEnumerator Registrar()
    {
        string[] datos = new string[4];
        print(servidor.user);
        datos[0] = servidor.user;
        datos[1] = "0";
        datos[2] = "0";
        datos[3] = impPuntos.text;
        StartCoroutine(servidor.ConsumirServicio("Puntaje", datos, PosCargar));
        yield return new WaitForSeconds(0.5f);
        yield return new WaitUntil(() => !servidor.ocupado);

    }

    void PosCargar()
    {
        switch (servidor.respuesta.codigo)
        {
            case 401: //Error intentando crear el usuario
                print(servidor.respuesta.mensaje);
                break;
            case 201: //Inicio de Sesión Correcto
                usuario = JsonUtility.FromJson<DBUsuario>(servidor.respuesta.respuesta);
                break;
            case 402: //Faltan datos para ejecutar la accion solicitada 
                print(servidor.respuesta.mensaje);
                break;
            case 400: //Error 
                print("Erro, no se puede conectar con el servidor");
                break;
            default:
                break;
        }
    }
}