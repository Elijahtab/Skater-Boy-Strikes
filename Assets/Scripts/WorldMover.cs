using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class WorldMover : MonoBehaviour
{
    public float moveSpeed;

    private static List<GameObject> allMovables;

    void Start()
    {
        allMovables = GameObject.FindGameObjectsWithTag("Scrolling").ToList();
    }

    void Update()
    {
        foreach(GameObject movable in allMovables)
        {
            movable.transform.Translate(-1 * moveSpeed * Time.deltaTime, 0, 0, Space.World);
        }
    }
    
    public static void addMovable(GameObject movableObj)
    {
        allMovables.Add(movableObj);
    }
}
