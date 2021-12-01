using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateRandom : MonoBehaviour
{
    public Transform pos;

    public GameObject[] objectsToInstantiate;

    public float respawningTimer;
    void Update()
    {
        Instantiation1();
    }
    private void Instantiation1()
    {
        respawningTimer -= Time.deltaTime;
        int n = Random.Range(0, objectsToInstantiate.Length);

        float posXGeneracion = Random.Range(-24, 14);
        float posZGeneracion = Random.Range(-3, 23);

        Vector3 posRand = new Vector3(posXGeneracion, 1, posZGeneracion);
        if (respawningTimer <= 0)
        {
            GameObject g = Instantiate(objectsToInstantiate[n], posRand, objectsToInstantiate[n].transform.rotation);
            respawningTimer = UnityEngine.Random.Range(5, 9);
        }
    }
}
