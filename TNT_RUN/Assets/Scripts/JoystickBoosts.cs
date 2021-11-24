using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickBoosts : MonoBehaviour
{
    public Transform player2;

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Jump"))
        {
            Player_Joystick.jumpSpeed = 20.0f;
            Player_Joystick.boost = true;
            Destroy(other.gameObject);
        }
        if (other.gameObject.CompareTag("Bomb"))
        {
            Bombs_Instantiator.cont = 1;
        }
        if (other.gameObject.CompareTag("Teleport"))
        {
            player2.GetComponent<CharacterController>().enabled = false;
            player2.transform.position = new Vector3(Random.Range(-17, 7), 9, Random.Range(-1, 20));
            player2.GetComponent<CharacterController>().enabled = true;
            Destroy(other.gameObject);
        }
    }
}
