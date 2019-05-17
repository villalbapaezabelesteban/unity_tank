using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraTopDown : MonoBehaviour
{
    private Transform tank;
    private Vector3 deltaObjetivo;
    public float velocidad = 1.0f;

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
        Vector3 posicionActual = transform.position;
        Vector3 posicionFinal = tank.position + deltaObjetivo;

        transform.position = Vector3.Lerp(posicionActual, posicionFinal, velocidad * Time.deltaTime);
    }
}