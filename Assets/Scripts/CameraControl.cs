using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public Transform target;
    public BoxCollider2D mapBounds;

    private float xMin, xMax, yMin, yMax;
    private float camY, camX;
    private float camOrthsize;
    private float cameraRatio;
    private Camera mainCam;

    /*private void Start()
    {
        mainCam = GetComponent<Camera>();

        xMin = mapBounds.bounds.min.x;
        xMax = mapBounds.bounds.max.x;
        yMin = mapBounds.bounds.min.y;
        yMax = mapBounds.bounds.max.y;
        
        camOrthsize = mainCam.orthographicSize;
        cameraRatio = (xMax + camOrthsize) / 2.0f;
    }*/

    void Update()
    {
        //camY = Mathf.Clamp(target.position.y, yMin + camOrthsize, yMax - camOrthsize);
        //camX = Mathf.Clamp(target.position.x, xMin + cameraRatio, xMax - cameraRatio);
        //transform.position = new Vector3(camX, camY, transform.position.z);
        transform.position = new Vector3(target.position.x, target.position.y, transform.position.z);
    }
}
