using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorArma : MonoBehaviour
{
    void Start()
    {
        
    }

    public Transform puntaCanion;
    public GameObject prefapBala;
    public float potenciaBala;

    void Update()
    {
        bool isFired = Input.GetButtonDown("Fire1");
        
        if (isFired)
        {
            GameObject bala = GameObject.Instantiate(prefapBala, puntaCanion.position, puntaCanion.rotation);

            Rigidbody balaRb = bala.GetComponent<Rigidbody>();

            if (balaRb != null)
            {
                balaRb.velocity = bala.transform.forward * potenciaBala;
            }
        }
    }
}
