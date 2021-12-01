using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala2 : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player2"))
        {
            StartCoroutine(CoolDown());
        }
    }
    IEnumerator CoolDown()
    {
        Player_Joystick.walkSpeed = 1.5f;
        yield return new WaitForSeconds(2);
        Player_Joystick.walkSpeed = 3.0f;
    }
}
