using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private Vector3 offset;
    [SerializeField] private float damping = 1.0f;

    public Transform target;
    private Vector3 velocity = Vector3.zero;
    private void Update()
    {
        Vector3 targetPosition = target.position + offset;
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref
            velocity, damping);
    }





}
