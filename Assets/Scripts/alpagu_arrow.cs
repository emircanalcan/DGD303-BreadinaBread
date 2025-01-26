using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class alpagu_arrow : MonoBehaviour
{
    void Update()
    {
        transform.position += Vector3.right * 16 * Time.deltaTime;
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "border_right")
        {
            Destroy(gameObject);
        }
    }
}