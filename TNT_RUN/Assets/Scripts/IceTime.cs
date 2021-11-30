using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceTime : MonoBehaviour
{
    public static float timer = 0;
    public Rigidbody Player_Teclado_RB;
    public Rigidbody Player_Joystick_RB;

    public CharacterController Player_Teclado_CC;
    public CharacterController Player_Joystick_CC;

    void Start()
    {
        Player_Teclado_RB.GetComponent<Rigidbody>();
        Player_Joystick_RB.GetComponent<Rigidbody>();

        Player_Teclado_CC.GetComponent<CharacterController>();
        Player_Joystick_CC.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= 4)
        {
            StartCoroutine(Frezze());
        }
    }
    IEnumerator Frezze()
    {
        Player_Teclado_RB.constraints = RigidbodyConstraints.FreezeAll;       
        Player_Joystick_RB.constraints = RigidbodyConstraints.FreezeAll;

        Player_Teclado_CC.enabled = false;
        Player_Joystick_CC.enabled = false;

        yield return new WaitForSeconds(3);
        Player_Joystick_RB.constraints &= ~RigidbodyConstraints.FreezePositionY;
        Player_Joystick_RB.constraints &= ~RigidbodyConstraints.FreezePositionX;
        Player_Joystick_RB.constraints &= ~RigidbodyConstraints.FreezePositionZ;

        Player_Teclado_RB.constraints &= ~RigidbodyConstraints.FreezePositionY;
        Player_Teclado_RB.constraints &= ~RigidbodyConstraints.FreezePositionX;
        Player_Teclado_RB.constraints &= ~RigidbodyConstraints.FreezePositionZ;

        Player_Teclado_CC.enabled = true;
        Player_Joystick_CC.enabled = true;

        timer = 0;
    }

}
