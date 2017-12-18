using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float paddleSpeed = 1;
    public Vector3 playerPos;

    void Update()
    {
        float yPos = gameObject.transform.position.y + (Input.GetAxis("Vertical") * paddleSpeed);
        playerPos = new Vector2(-7, Mathf.Clamp(yPos, -4, 4));
        gameObject.transform.position = playerPos;
    }
}