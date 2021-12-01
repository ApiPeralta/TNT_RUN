using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TogglePosion : MonoBehaviour
{
    public Toggle toggle;

    void Update()
    {
        if (toggle.isOn)
        {
            Act_Desact.valuePosion = 1;
        }
        else
            Act_Desact.valuePosion = 0;
    }
}
