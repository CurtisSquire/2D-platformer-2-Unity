using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CameraFollow : MonoBehaviour
{
    //use variables to set the player as the target to follow and I used empty gameobjects 
    //transform locations to tell the camera what bounds to stay in
    [SerializeField] Transform target;
    [SerializeField] Transform camBoundMin;
    [SerializeField] Transform camBoundMax;
    private float xMin;
    private float yMin;
    private float xMax;
    private float yMax;

    private void Start()
    {
        // set floats to empty gameobject positions. 
        
        xMin = camBoundMin.position.x;
        yMin = camBoundMin.position.y;
        xMax = camBoundMax.position.x;
        yMax = camBoundMax.position.y;
    }

    private void Update()
    {
        //if the target has been assined follow them while staying in the bounds set. 
        if (target)
        {
            transform.position = new Vector3(Mathf.Clamp(target.position.x, xMin, xMax), Mathf.Clamp(target.position.y, yMin, yMax), transform.position.z);
        }
    }
}
