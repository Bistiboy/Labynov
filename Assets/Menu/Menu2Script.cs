using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu2Script : MonoBehaviour
{
    public void LancerLabyrinthe1()
    {
        SceneManager.LoadScene("Scene19x19");
    }

    public void LancerLabyrinthe2()
    {
        SceneManager.LoadScene("Scene13x13");
    }

    public void LancerLabyrinthe3()
    {
        SceneManager.LoadScene("Scene9x9");
    }
}
