using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barra_Speed : MonoBehaviour
{
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        rb.AddForce(new Vector3(500, 0, 0), ForceMode.Force);
        Destroy(this.gameObject, 6);
    }
}
