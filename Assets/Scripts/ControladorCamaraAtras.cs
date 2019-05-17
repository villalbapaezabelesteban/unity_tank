using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorCamaraAtras : MonoBehaviour
{
    private Transform tank;
    public float velocidad = 1.0f;
    public float distAtras = 4.0f;
    public float distArriba = 4.0f;
    public float distMirar;

    void Start()
    {
        GameObject gameObject = GameObject.FindWithTag("Tank");

        if (gameObject != null)
        {
            tank = gameObject.transform;
        }
    }

    void Update()
    {
        if (tank != null)
        {
            Vector3 posDeseoCamara =    tank.position -
                                        tank.forward * distAtras +
                                        Vector3.up * distArriba;

            //Lerp (interpolación lineal)
            //Slerp (Interpolación esferica)
            transform.position = Vector3.Slerp(transform.position, posDeseoCamara, velocidad * Time.deltaTime);
            //transform.position = Vector3.Lerp(transform.position, posDeseoCamara, velocidad * Time.deltaTime);

            Vector3 adelanteObjetivo = tank.position +
                                        tank.forward * distMirar;

            transform.rotation = Quaternion.LookRotation(adelanteObjetivo - transform.position);
        }
    }
}