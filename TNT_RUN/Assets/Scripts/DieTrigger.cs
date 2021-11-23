using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DieTrigger : MonoBehaviour
{
    private int teclado_Die = 0;
    private int joystick_Die = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            teclado_Die = 1;
        }
        if (other.gameObject.CompareTag("Player2"))
        {
            joystick_Die = 1;
        }
    }
}
