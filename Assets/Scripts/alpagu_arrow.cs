using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class alpagu_arrow : MonoBehaviour
{
    public GameObject item_arrow;
    public GameObject item_food;
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
        if (collision.gameObject.name == "obstacle_barricade" || collision.gameObject.name == "obstacle_barricade(Clone)")
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
            Instantiate(item_arrow, transform.position + new Vector3(1.28f, 0, 0), transform.rotation);
        }
        if (collision.gameObject.name == "obstacle_house" || collision.gameObject.name == "obstacle_house(Clone)")
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
            Instantiate(item_food, transform.position + new Vector3(1.28f, 0, 0), transform.rotation);
        }
    }
}