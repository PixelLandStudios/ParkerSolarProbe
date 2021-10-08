using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{

    public void MenuScene()
    {
        SceneManager.LoadScene("MenuScene");
    }

    public void ParkerScene()
    {
        SceneManager.LoadScene("ParkerSolarProbeScene");
    }

    public void OtherScene()
    {
        SceneManager.LoadScene("SunProbesScene");
    }

}
