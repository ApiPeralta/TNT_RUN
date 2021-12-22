using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DieTrigger : MonoBehaviour
{
    private int teclado_Die = 0;
    private int joystick_Die = 0;

    public GameObject winTeclado;
    public GameObject winJoystick;

    public Rigidbody Player_Teclado_RB;
    public Rigidbody Player_Joystick_RB;

    public CharacterController Player_Teclado_CC;
    public CharacterController Player_Joystick_CC;
    private void Start()
    {
        Player_Teclado_RB.GetComponent<Rigidbody>();
        Player_Joystick_RB.GetComponent<Rigidbody>();
        Player_Teclado_CC.GetComponent<CharacterController>();
        Player_Joystick_CC.GetComponent<CharacterController>();
        winJoystick.SetActive(false);
        winTeclado.SetActive(false);
    }
    private void Update()
    {
        if (teclado_Die == 1)
        {
            winJoystick.SetActive(true);
            StartCoroutine(GoToMenu());
        }
        if (joystick_Die == 1)
        {
            winTeclado.SetActive(true);
            StartCoroutine(GoToMenu());
        }
    }
    IEnumerator GoToMenu()
    {
        Player_Teclado_RB.constraints = RigidbodyConstraints.FreezeAll;
        Player_Joystick_RB.constraints = RigidbodyConstraints.FreezeAll;
        Player_Teclado_CC.enabled = false;
        Player_Joystick_CC.enabled = false;
        yield return new WaitForSeconds(7);
        SceneManager.LoadScene("Menu", LoadSceneMode.Additive);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            teclado_Die = 1;
        }
        if (other.gameObject.CompareTag("Player2"))
        {
            joystick_Die = 1;
        }
    }
}
