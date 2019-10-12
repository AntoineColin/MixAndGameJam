using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowingCamera : MonoBehaviour
{
    
    public Transform target;
    public float distance;

    // Update is called once per frame
    void Update()
    {
        transform.position = target.position + new Vector3(0, 0, distance);
    }
}
