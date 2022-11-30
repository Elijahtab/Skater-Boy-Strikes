using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

// By: Nicolas Assakura Miyazaki
public class WorldMover : MonoBehaviour
{
    [SerializeField]
    private float levelDestroyBound;

    public float moveSpeed;

    private static List<GameObject> allMovables;

    void Start()
    {
        allMovables = GameObject.FindGameObjectsWithTag("Scrolling").ToList();
        StartCoroutine(LevelDestroyCheck());
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

    public static void removeMoveable(GameObject moveableObj)
    {
        allMovables.Remove(moveableObj);
    }

    /* This checks for platforms that have traveled "levelDestroyBound" units to the left and
     * destroys them. This is a coroutine because it is a bit costly as it checks all moveable 
     * platforms' positions. As a coroutine, this can be run only once every tenth of a second
     * instead of every frame.
     */
    private IEnumerator LevelDestroyCheck()
    {
        while (true)
        {
            List<int> toDestroy = new List<int>();
            foreach(GameObject moveable in allMovables)
            {
                if (moveable.transform.position.x <= levelDestroyBound)
                {
                    toDestroy.Add(allMovables.IndexOf(moveable));
                }
            }

            foreach(int indToDestroy in toDestroy)
            {
                Destroy(allMovables[indToDestroy]);
                allMovables.RemoveAt(indToDestroy);
            }
            yield return new WaitForSeconds(0.1f);
        }
    }
}
