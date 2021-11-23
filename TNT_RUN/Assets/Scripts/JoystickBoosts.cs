using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickBoosts : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

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
    }
}
