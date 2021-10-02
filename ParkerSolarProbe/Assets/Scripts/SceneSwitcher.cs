using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{

    public void MenuScene()
    {
        SceneManager.LoadScene(1);
    }

    public void ParkerScene()
    {
        SceneManager.LoadScene(2);
    }

    public void OtherScene()
    {
        SceneManager.LoadScene(3);
    }

}
