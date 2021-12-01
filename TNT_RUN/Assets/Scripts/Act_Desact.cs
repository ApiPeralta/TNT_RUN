using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Act_Desact : MonoBehaviour
{
    public static int valueCanon = 0;
    public static int valueBarrier = 0;
    public static int valueIce = 0;
    public GameObject Canon;
    public GameObject Barrier;
    public GameObject Ice;
    public GameObject IceBarra;
    private void Start()
    {
        Canon.gameObject.SetActive(false);
        Barrier.gameObject.SetActive(false);
        Ice.gameObject.SetActive(false);
        IceBarra.gameObject.SetActive(false);
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
        if (valueIce == 1)
        {
            Ice.gameObject.SetActive(true);
            IceBarra.gameObject.SetActive(true);
        }
    }
}
