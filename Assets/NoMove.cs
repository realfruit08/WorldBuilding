using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoMove : MonoBehaviour
{



    public float maxYPosition = 3.7f;
    public float minYPosition = -3.1f;
    public float maxXPosition = 7.7f;
    public float minXPosition = -7.7f;

    void Update()
    {
       

        Vector3 position = transform.position;



        
        if (position.y > maxYPosition)
        {
           
            position.y = maxYPosition;
            transform.position = position;
        }

        if (position.y < minYPosition)
        {

            position.y = minYPosition;
            transform.position = position;
        }

        if (position.x > maxXPosition)
        {

            position.x = maxXPosition;
            transform.position = position;
        }

        if (position.x < minXPosition)
        {

            position.x = minXPosition;
            transform.position = position;
        }
    }
}
