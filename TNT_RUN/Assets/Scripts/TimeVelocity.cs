using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeVelocity : MonoBehaviour
{
    private float timer = 0;
    void Update()
    {
        timer += Time.deltaTime;
        
        if(timer >= 20 && timer<= 35)
        {
            Player_Movement.walkSpeed = 5;
            Player_Joystick.walkSpeed = 5;
        }
        else if (timer >= 35 && timer <= 50)
        {
            Player_Movement.walkSpeed = 7;
            Player_Joystick.walkSpeed = 7;
        }
        else if (timer >= 50)
        {
            Player_Movement.walkSpeed = 10;
            Player_Joystick.walkSpeed = 10;
        }
    }
}
