using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walls : MonoBehaviour
{
    //var to control the speed of spawning
    public float speed = 5f;

    //var to store the value of leftEdge of the screen
    private float leftEdge;

    //in this function we are getting the X coordinate to get the left Edge
    private void Start()
    {
        leftEdge = Camera.main.ScreenToWorldPoint(Vector3.zero).x;
    }

    //function to update the position of walls
    private void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        //logic of "if leftEdge is passed, then remove the walls"
        if (transform.position.x < leftEdge)
        {
            Destroy(gameObject);
        }
    }
}
