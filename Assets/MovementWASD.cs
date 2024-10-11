using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementWASD : MonoBehaviour
{
    // Start is called before the first frame update
    void Update()
    {
        float moveSpeed = 10f;
        Input.GetKey(KeyCode.W);
        Input.GetKey(KeyCode.S);
        Input.GetKey(KeyCode.A);
        Input.GetKey(KeyCode.D);
        if (Input.GetKey(KeyCode.W))
        {
            Debug.Log("Pressing W");
            transform.position += Vector3.up * Time.deltaTime * moveSpeed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            Debug.Log("Pressing S");
            transform.position += Vector3.down * Time.deltaTime * moveSpeed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("Pressing A");
            transform.position += Vector3.left * Time.deltaTime * moveSpeed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("Pressing D");
            transform.position += Vector3.right * Time.deltaTime * moveSpeed;
        }
    }
}

