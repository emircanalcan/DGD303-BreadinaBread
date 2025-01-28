using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class obstacle_tree : MonoBehaviour
{
    void Update()
    {
        transform.position += Vector3.left * 8 * Time.deltaTime;
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "border_left")
        {
            Destroy(gameObject);
        }
    }
}