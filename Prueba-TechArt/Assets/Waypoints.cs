using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoints : MonoBehaviour
{
    [SerializeField] private GameObject[] waypoints;
    [SerializeField] private float speed;
    private Vector3 currentPos, targetPos;
    private int currentWaypoint;
    // Start is called before the first frame update
    void Start()
    {
        currentPos = transform.position;
        targetPos = waypoints[0].transform.position;
        currentWaypoint = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position != targetPos)
        {
            //transform.position = Vector3.Lerp(transform.position, targetPos,);
            transform.position = Vector3.MoveTowards(transform.position, targetPos, speed);
        }
        else if (currentWaypoint < waypoints.Length -1)
        {
            currentWaypoint++;
            targetPos = waypoints[currentWaypoint].transform.position;
        }
    }
}
