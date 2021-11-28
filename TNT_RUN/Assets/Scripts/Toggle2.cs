using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Toggle2 : MonoBehaviour
{

    public Toggle toggle;

    void Update()
    {
        if (toggle.isOn)
        {
            Act_Desact.valueBarrier = 1;
            Debug.Log(Act_Desact.valueBarrier);
        }
        else
            Act_Desact.valueBarrier = 0;
    }
}
