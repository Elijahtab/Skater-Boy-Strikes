using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMover : MonoBehaviour
{
    [SerializeField]
    private int backgroundSpeed;
    [SerializeField]
    private float reset;

    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        transform.position += new Vector3(-backgroundSpeed * Time.deltaTime, 0f, 0f);
        if (transform.position.x < reset)
        {
            transform.position = startPos;
        }
    }
}
