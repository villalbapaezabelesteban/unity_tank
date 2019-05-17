using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorBala : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.CompareTag("Player"))
        {
            GameObject.Destroy(gameObject);
        }
    }
}
