using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollow : MonoBehaviour
{
    public Transform playerTransform;
    private Vector3 cameraOffset;
    private float smoothFactor = 0.125f;
    private bool lookAtPlayer = true;
    bool fpsCam = false;
    // Start is called before the first frame update
    void Start()
    {
        cameraOffset = transform.position - playerTransform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 desiredPosition = playerTransform.position + cameraOffset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothFactor);
        transform.position = smoothedPosition;
    }
}
