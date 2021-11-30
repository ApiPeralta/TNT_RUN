using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ToggleIce : MonoBehaviour
{
    public Toggle toggle;

    void Update()
    {
        if (toggle.isOn)
        {
            Act_Desact.valueIce = 1;
            Debug.Log(Act_Desact.valueIce);
        }
        else
            Act_Desact.valueIce = 0;
    }
}
