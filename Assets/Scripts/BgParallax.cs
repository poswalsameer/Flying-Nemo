using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgParallax : MonoBehaviour
{
    private MeshRenderer meshRenderer;

    //variable to control the speed to move the bg
    public float bgMoveRate = 1f;

    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    private void Update()
    {
        meshRenderer.material.mainTextureOffset += new Vector2(bgMoveRate * Time.deltaTime, 0);
    }
}
