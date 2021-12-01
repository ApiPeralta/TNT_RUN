using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            StartCoroutine(CoolDown());
        }
    }
    IEnumerator CoolDown()
    {
        Player_Movement.walkSpeed = 1.5f;
        yield return new WaitForSeconds(2);
        Player_Movement.walkSpeed = 3.0f;
    }
}
