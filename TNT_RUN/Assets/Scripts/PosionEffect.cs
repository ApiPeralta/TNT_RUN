using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PosionEffect : MonoBehaviour
{
    public Camera camA;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            camA = other.gameObject.GetComponent<Player_Movement>().cam;
            camA.fieldOfView = 20;
            StartCoroutine(popoposion(5, camA));
        }
        if (other.gameObject.CompareTag("Player2"))
        {
            camA = other.gameObject.GetComponent<Player_Joystick>().cam;
            camA.fieldOfView = 20;
            StartCoroutine(popoposion(5, camA));
        }
    }
    IEnumerator popoposion(float time, Camera cam)
    {
        yield return new WaitForSeconds(time);
        cam.fieldOfView = 60;
    }
}
