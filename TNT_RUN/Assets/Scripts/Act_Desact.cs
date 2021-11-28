using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Act_Desact : MonoBehaviour
{
    public static int valueCanon = 0;
    public static int valueBarrier = 0;
    public GameObject Canon;
    public GameObject Barrier;
    private void Start()
    {
        Canon.gameObject.SetActive(false);
        Barrier.gameObject.SetActive(false);
    }
    void Update()
    {
        if(valueCanon == 1)
        {
            Canon.gameObject.SetActive(true);
        }
        if (valueBarrier == 1)
        {
            Barrier.gameObject.SetActive(true);
        }
    }
}
