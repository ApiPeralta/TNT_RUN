using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activation : MonoBehaviour
{
    public static int piso2_Cont = 0;
    private void OnTriggerEnter(Collider other)
    {
        if((other.gameObject.CompareTag("Player")) || (other.gameObject.CompareTag("Player2")))
        {
            piso2_Cont++;
            Destroy(this.gameObject);
        }
    }
}
