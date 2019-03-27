using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Camera))]
public class FollowCamera : MonoBehaviour {

    public Camera cameraToFollow;
    Transform transformToFollow;
    Transform cachedTransform;
    Camera cachedCamera;

    // Use this for initialization
    void Start () {
        transformToFollow = cameraToFollow.transform;
        cachedTransform = transform;
        cachedCamera = GetComponent<Camera>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        cachedTransform.position = transformToFollow.position;
        cachedTransform.rotation = transformToFollow.rotation;
        
        cachedCamera.fieldOfView = cameraToFollow.fieldOfView;
    }
}
