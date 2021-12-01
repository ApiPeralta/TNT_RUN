using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleScript : MonoBehaviour
{

    public Toggle toggle;

    void Update()
    {
        if (toggle.isOn)
        {
            Act_Desact.valueCanon = 1;
            Debug.Log(Act_Desact.valueCanon);
        }
        else
            Act_Desact.valueCanon = 0;
    }
}
