using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    private void Start()
    {
        //m_Toggle = GetComponent<Toggle>();
    }
    public void Classic()
    {
        SceneManager.LoadScene(1);
    }
    public void Tower()
    {
        SceneManager.LoadScene(2);
    }
}

