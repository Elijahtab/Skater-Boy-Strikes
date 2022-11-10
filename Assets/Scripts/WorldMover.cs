using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class WorldMover : MonoBehaviour
{
    public float moveSpeed;

    private List<GameObject> allMovables;

    void Start()
    {
        allMovables = GameObject.FindGameObjectsWithTag("Scrolling").ToList();
    }

    void Update()
    {
        foreach(GameObject movable in allMovables)
        {
            movable.transform.Translate(-1 * moveSpeed * Time.deltaTime, 0, 0);
        }
    }

    public void addMovable(GameObject movableObj)
    {
        allMovables.Add(movableObj);
    }
}
