using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TecladoBoosts : MonoBehaviour
{
    public Transform player;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Jump"))
        {
            Player_Movement.jumpSpeed = 20.0f;
            Player_Movement.boost2 = true;
            Destroy(other.gameObject);
        }
        if (other.gameObject.CompareTag("Bomb"))
        {
            Bomb_Instantiator_Tower.cont = 1;
            Bombs_Instantiator.cont = 1;
            Destroy(other.gameObject);
        }
        if (other.gameObject.CompareTag("Teleport"))
        {
            player.GetComponent<CharacterController>().enabled = false;
            player.transform.position = new Vector3(Random.Range(-17, 7), 9, Random.Range(-1, 20));
            player.GetComponent<CharacterController>().enabled = true;
            Destroy(other.gameObject);
        }
    }
}
