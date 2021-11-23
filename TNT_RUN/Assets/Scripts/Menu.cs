using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void Classic()
    {
        SceneManager.LoadScene(1);
    }
    public void Tower()
    {
        SceneManager.LoadScene(2);
    }
}

