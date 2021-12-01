using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerBoostTeclado : MonoBehaviour
{
    public float respawningTimer;
    void Update()
    {
        if (Player_Movement.boost2 == true)
        {
            respawningTimer += Time.deltaTime;
            if (respawningTimer >= 3)
            {
                Player_Movement.jumpSpeed = 7.0f;
                Player_Movement.boost2 = false;
                respawningTimer = 0;
            }
        }
    }
}
