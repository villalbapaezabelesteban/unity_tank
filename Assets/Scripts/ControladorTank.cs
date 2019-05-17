using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorTank : MonoBehaviour
{
    private Rigidbody rigidbody;
    private float h;
    private float v;
    public float velVert;
    public float velHor;
    void Start()
    {
        rigidbody = gameObject.GetComponent<Rigidbody>();
    }

    void Update()
    {
        h = Input.GetAxis("Horizontal2");
        v = Input.GetAxis("Vertical2");
    }

    void FixedUpdate()
    {
        if (rigidbody != null)
        {
            rigidbody.velocity = v * transform.forward * velVert +
                Vector3.up * rigidbody.velocity.y;
            rigidbody.angularVelocity = new Vector3(0f, velHor * h, 0f);
        }
    }
}
