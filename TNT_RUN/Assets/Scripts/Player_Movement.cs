using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player_Movement : MonoBehaviour
{
    CharacterController characterController;
    [Header("Opciones de personaje")]
    public float walkSpeed = 3.0f;
    public static float jumpSpeed = 7.0f;
    public float gravity = 20.0f;

    [Header("Opciones de camara")]
    public Camera cam;
    public float mouseHorizontal = 3.0f;
    public float mouseVertical = 2.0f;

    public float minRotation = -65.0f;
    public float maxRotation = 60.0f;
    float h_mouse, v_mouse;


    private Vector3 move = Vector3.zero;


    public static bool boost2 = false;

    void Start()
    {
        characterController = GetComponent<CharacterController>();

        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        h_mouse = mouseHorizontal * Input.GetAxis("Mouse X");
        v_mouse += mouseVertical * Input.GetAxis("Mouse Y");

        v_mouse = Mathf.Clamp(v_mouse, minRotation, maxRotation);


        cam.transform.localEulerAngles = new Vector3(-v_mouse, 0, 0);

        transform.Rotate(0, h_mouse, 0);


        if (characterController.isGrounded)
        {
            move = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));

            if (Input.GetKey(KeyCode.LeftShift))
                move = transform.TransformDirection(move);
            else
                move = transform.TransformDirection(move) * walkSpeed;

            if (Input.GetKeyDown(KeyCode.Space))
            {
                move.y = jumpSpeed;
            }
        }
        move.y -= gravity * Time.deltaTime;
        characterController.Move(move * Time.deltaTime);
    }
    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.gameObject.CompareTag("Jump"))
    //    {
    //        jumpSpeed = 20.0f;
    //        boost2 = true;
    //        Destroy(other.gameObject);
    //    }
    //}
}
