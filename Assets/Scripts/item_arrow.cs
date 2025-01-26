using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class item_arrow : MonoBehaviour
{
    void Update()
    {
        transform.position += Vector3.left * 8 * Time.deltaTime;
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "border_left")
        {
            Destroy(gameObject);
        }
    }
}