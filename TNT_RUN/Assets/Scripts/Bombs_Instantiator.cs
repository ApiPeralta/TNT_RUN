using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bombs_Instantiator : MonoBehaviour
{
    public static int cont = 0;
    public GameObject bomb;
    void Update()
    {
        if (cont == 1)
        {
            Instantiation1();
            cont = 0;
        }
    }
    private void Instantiation1()
    {
        float posXGeneracion = Random.Range(-24, 14);
        float posZGeneracion = Random.Range(-3, 23);

        Vector3 posRand = new Vector3(posXGeneracion, 8, posZGeneracion);

        GameObject g = Instantiate(bomb, posRand, bomb.transform.rotation);

    }
}

