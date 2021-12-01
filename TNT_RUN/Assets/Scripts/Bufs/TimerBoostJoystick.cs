using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerBoostJoystick : MonoBehaviour
{
    public float respawningTimer;
    void Update()
    {    
        if (Player_Joystick.boost == true)
        {
            respawningTimer += Time.deltaTime;
            if (respawningTimer >= 3)
            {                
                Player_Joystick.jumpSpeed = 7.0f;
                Player_Joystick.boost = false;
                respawningTimer = 0;
            }
        }
    }
}
