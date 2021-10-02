using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Popup : MonoBehaviour
{
    public GameObject PopUpScreen;

    public void Move()
    {
        PopUpScreen.transform.position = new Vector3(550, 250, 0);
    }

    public void Remove()
    {
        PopUpScreen.transform.position = new Vector3(13000, 12000, 0);
    }
}
