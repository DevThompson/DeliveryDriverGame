using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField]  GameObject playerFollow;
    [SerializeField]  Vector3 cameraVector;
    //Moves the camera's position to that of the car

    // Update is called once per frame
    void Update()
    {
        transform.position = playerFollow.transform.position + cameraVector;
    }
}
