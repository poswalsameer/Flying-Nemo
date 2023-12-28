using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Vector3 direction;

    //variable to change gravity according to the game
    public float gravity = -9.8f;
    //a variable used to control the strength of the flying of the bird
    public float flyStrength = 5f;

    private void Update()
    {
        //if player taps the space bar, then bird flies
        if( Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow) )
        {
            direction = Vector3.up * flyStrength ;
        }

        //logic for touchscreen to fly the birds
        if( Input.touchCount > 0 )
        {
            Touch touch = Input.GetTouch(0);

            if( touch.phase == TouchPhase.Began )
            {
                direction = Vector3.up * flyStrength;
            }
        }

        direction.y += gravity * Time.deltaTime;
        transform.position += direction * Time.deltaTime;



    }
}
