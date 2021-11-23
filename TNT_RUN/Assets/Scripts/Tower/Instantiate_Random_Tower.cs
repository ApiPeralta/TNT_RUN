using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate_Random_Tower : MonoBehaviour
{
    public Transform pos;

    public GameObject[] objectsToInstantiate;

    public float respawningTimer;
    void Update()
    {
        if (Activation.piso2_Cont == 1)
        {
            Instantiation1();
            Instantiation2();
        }
        if (Activation.piso2_Cont == 2)
        {
            Instantiation1();
            Instantiation2();
            Instantiation3();
        }
        else
        {
            Instantiation1();
        }
    }
    private void Instantiation1()
    {
        respawningTimer -= Time.deltaTime;
        int n = Random.Range(0, objectsToInstantiate.Length);

        float posXGeneracion = Random.Range(-15, 7);
        float posZGeneracion = Random.Range(-1, 20);

        Vector3 posRand = new Vector3(posXGeneracion, 1, posZGeneracion);
        if (respawningTimer <= 0)
        {
            GameObject g = Instantiate(objectsToInstantiate[n], posRand, objectsToInstantiate[n].transform.rotation);
            respawningTimer = UnityEngine.Random.Range(5, 9);
        }
    }
    private void Instantiation2()
    {
        respawningTimer -= Time.deltaTime;
        int n = Random.Range(0, objectsToInstantiate.Length);

        float posXGeneracion = Random.Range(-15, 7);
        float posZGeneracion = Random.Range(-1, 20);

        Vector3 posRand = new Vector3(posXGeneracion, -7, posZGeneracion);
        if (respawningTimer <= 0)
        {
            GameObject g = Instantiate(objectsToInstantiate[n], posRand, objectsToInstantiate[n].transform.rotation);
            respawningTimer = UnityEngine.Random.Range(5, 9);
        }
    }
    private void Instantiation3()
    {
        respawningTimer -= Time.deltaTime;
        int n = Random.Range(0, objectsToInstantiate.Length);

        float posXGeneracion = Random.Range(-15, 7);
        float posZGeneracion = Random.Range(-1, 20);

        Vector3 posRand = new Vector3(posXGeneracion, -18, posZGeneracion);
        if (respawningTimer <= 0)
        {
            GameObject g = Instantiate(objectsToInstantiate[n], posRand, objectsToInstantiate[n].transform.rotation);
            respawningTimer = UnityEngine.Random.Range(5, 9);
        }
    }
}
