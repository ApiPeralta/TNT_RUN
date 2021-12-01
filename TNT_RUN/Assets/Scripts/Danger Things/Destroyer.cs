using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if ((collision.gameObject.CompareTag("Player")) || (collision.gameObject.CompareTag("Player2")))
        {
            StartCoroutine(BlockDestroy());
        }
        if (collision.gameObject.CompareTag("BOMB"))
        {
            Destroy(this.gameObject);
        }
    }
    IEnumerator BlockDestroy()
    {
        yield return new WaitForSeconds(1);
        Destroy(this.gameObject);
    }
}
