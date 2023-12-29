using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickSpawning : MonoBehaviour
{
    public GameObject prefab;

    //variable to store the spawning rate
    public float spawnRate = 1f;

    //variables to adjust the height of new spawned walls
    public float minHeight = -1f;
    public float maxHeight = +1f;

    //function to that will invoke the spawning function to show walls at the rate of "spawnRate"
    private void OnEnable()
    {
        InvokeRepeating( nameof(spawn), spawnRate, spawnRate );
    }

    //function to disable the spawning function
    private void OnDisable()
    {
        CancelInvoke( nameof(spawn) );
    }

    //main function that will spawn walls
    private void spawn()
    {
        //this was done to make sure the walls are spawned from the right end of the screen
        //here in this vector3, the z-value has been set to 1 by hit and trial because the walls were not visible due to some kind of layering issue
        Vector3 spawnPosition = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Random.Range(0, Screen.height), 1));

        GameObject walls = Instantiate(prefab, spawnPosition, Quaternion.identity );

        walls.transform.position += Vector3.up * Random.Range( minHeight, maxHeight );   
    }

    //this comment has been added to check if the github repo is responding or not
    }



