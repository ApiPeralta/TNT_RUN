using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barra_Inst : MonoBehaviour
{
    private float respawningTimer = 1;
    public Rigidbody barra;
    public GameObject pos;
    public GameObject barraObj;
    void Start()
    {
        barra.GetComponent<Rigidbody>();
    }
    private void Update()
    {
        Spawn();
    }
    private void Spawn()
    {
        respawningTimer -= Time.deltaTime;
        if (respawningTimer <= 0)
        {
            Instantiate(barraObj, pos.GetComponent<Transform>().position, Quaternion.identity);
            respawningTimer = UnityEngine.Random.Range(10, 11);
        }
    }
}
