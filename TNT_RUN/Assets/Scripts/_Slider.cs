using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class _Slider : MonoBehaviour
{
    public Slider timerA;
    public static float timerr = 25;
    private void Start()
    {
        
    }
    void Update()
    {
        timerr -= Time.deltaTime;
        timerA.value = timerr;
    }
}
