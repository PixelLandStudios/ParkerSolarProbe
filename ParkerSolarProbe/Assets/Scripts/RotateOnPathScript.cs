using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateOnPathScript : MonoBehaviour
{
    int i = 0;
    float speed = 2f;
    Transform sunTransform;

    [SerializeField]
    List<Vector3> PathPoints;

    // Start is called before the first frame update
    void Start()
    {
        sunTransform = GameObject.FindGameObjectWithTag("Sun").transform;
    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;

        Vector3 target = PathPoints[i];
        transform.position = Vector3.MoveTowards(transform.position, target, step);
        if (transform.position == target)
        {
            Debug.Log(i + " : " + target);
            i++;

            if (i >= PathPoints.Count)
                i = 0;
        }

        this.transform.LookAt(2 * this.transform.position - sunTransform.position, Vector3.up);
    }
}
