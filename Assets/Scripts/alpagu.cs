using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class alpagu : MonoBehaviour
{
    public Rigidbody2D alpagurigidbody2D;
    void Start()
    {

    }
    void Update()
    {
        Vector2 movement = Vector2.zero;
        if (Input.GetKey(KeyCode.UpArrow)|| Input.GetKey(KeyCode.W))
        {
            movement.y = 1;
        }
        if (Input.GetKey(KeyCode.DownArrow)|| Input.GetKey(KeyCode.S))
        {
            movement.y = -1;
        }
        if (Input.GetKey(KeyCode.LeftArrow)|| Input.GetKey(KeyCode.A))
        {
            movement.x = -1;
        }
        if (Input.GetKey(KeyCode.RightArrow)|| Input.GetKey(KeyCode.D))
        {
            movement.x = 1;
        }
        alpagurigidbody2D.velocity = movement.normalized * 8f;
    }
}