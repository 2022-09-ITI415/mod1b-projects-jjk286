using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNewScene : MonoBehaviour
{

    public void LoadScene1()
    {
        SceneManager.LoadScene("_Scene_o");
    }

    public void LoadScene2()
    {
        SceneManager.LoadScene("_Scene_0");
    }

    public void LoadScene3()
    {
        SceneManager.LoadScene("Main-Prototype 1");
    }

    

}
