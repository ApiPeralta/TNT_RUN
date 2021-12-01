using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlindPosion : MonoBehaviour
{
    public GameObject Posion;
    public float timer = 0;
    void Update()
    {
        timer += Time.deltaTime;
        float posXGeneracion = Random.Range(-17, 7);
        float posZGeneracion = Random.Range(-1, 20);

        Vector3 posRand = new Vector3(posXGeneracion, 30, posZGeneracion);
        if (timer >= 4)
        {
            GameObject g = Instantiate(Posion, posRand, Posion.transform.rotation);
            timer = 0;
        }
    }
}
