using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowingCam : MonoBehaviour
{
	Transform target;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("Character").transform;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = target.position + new Vector3(0,0,-10);
    }
}
