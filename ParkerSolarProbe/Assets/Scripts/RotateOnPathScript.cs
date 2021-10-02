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

    public float alpha = 0f;

    public float tilt = 45f;

    // Update is called once per frame
    void Update()
    {
        //float step = speed * Time.deltaTime;

        //Vector3 target = PathPoints[i];
        //transform.position = Vector3.MoveTowards(transform.position, target, step);
        //if (transform.position == target)
        //{
        //    Debug.Log(i + " : " + target);
        //    i++;

        //    if (i >= PathPoints.Count)
        //        i = 0;
        //}

        this.transform.LookAt(2 * this.transform.position - sunTransform.position, Vector3.up);

        //transform.position = new Vector3(0f + (10f * MCos(alpha) * MCos(tilt)) - (5f * MSin(alpha) * MSin(tilt)), 0,
        //                             0f + (10f * MCos(alpha) * MSin(tilt)) + (5f * MSin(alpha) * MCos(tilt)));

        transform.position = new Vector3(0f + (5f * MCos(alpha) * MCos(tilt)) - (2.5f * MSin(alpha) * MSin(tilt)), 0,
                                     0f + (5f * MCos(alpha) * MSin(tilt)) + (2.5f * MSin(alpha) * MCos(tilt)));
        alpha += 0.08f;
    }

    float MCos(float value)
    {
        return Mathf.Cos(Mathf.Deg2Rad * value);
    }

    float MSin(float value)
    {
        return Mathf.Sin(Mathf.Deg2Rad * value);
    }
}
