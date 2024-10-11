using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CAmera : MonoBehaviour
{
    // Start is called before the first frame update

    public float FollowSpeed = 1.0f;
    public Transform target;

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = new Vector3(target.position.x, target.position.y);
        transform.position = Vector3.Slerp(transform.position, newPos, FollowSpeed * Time.deltaTime);
    }
}
