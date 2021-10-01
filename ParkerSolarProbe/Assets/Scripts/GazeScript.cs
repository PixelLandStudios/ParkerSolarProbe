using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GazeScript : MonoBehaviour
{
    GameObject selectedProbe;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hit, 3f))
        {
            if (hit.collider.gameObject.tag == "Probe")
            {
                selectedProbe = hit.collider.gameObject;
                selectedProbe.transform.Find("Canvas/Image").GetComponent<Image>().enabled = true;
            }
        }
        else
        {
            if (selectedProbe != null)
            {
                selectedProbe.transform.Find("Canvas/Image").GetComponent<Image>().enabled = false;
                selectedProbe = null;
            }
        }
    }
}
