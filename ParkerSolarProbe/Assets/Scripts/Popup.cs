using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Popup : MonoBehaviour
{
    public GameObject PopUpScreen;

    public void Move()
    {
        PopUpScreen.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 550);
    }

    public void Remove()
    {
        PopUpScreen.GetComponent<RectTransform>().anchoredPosition = new Vector2(13000, 12000);
    }
}
