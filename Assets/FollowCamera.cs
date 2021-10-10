using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject thingsToFollow;
    //this thing's position should be same as car's position.

    // Start is called before the first frame update
    
    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = thingsToFollow.transform.position + new Vector3(0, 0, -10);
    }
}
