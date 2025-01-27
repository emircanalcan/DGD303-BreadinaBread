using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class alpagu_swordslash : MonoBehaviour
{
    public GameObject item_arrow;
    public GameObject item_food;
    void Start()
    {
        Destroy(gameObject, 0.2f);
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "obstacle_barricade" || collision.gameObject.name == "obstacle_barricade(Clone)")
        {
            Destroy(collision.gameObject);
            Instantiate(item_arrow, transform.position + new Vector3(1.28f, 0, 0), transform.rotation);
        }
        if (collision.gameObject.name == "obstacle_house" || collision.gameObject.name == "obstacle_house(Clone)")
        {
            Destroy(collision.gameObject);
            Instantiate(item_food, transform.position + new Vector3(1.28f, 0, 0), transform.rotation);
        }
        if (collision.gameObject.name == "chinese_bow1" || collision.gameObject.name == "chinese_bow1(Clone)" ||
            collision.gameObject.name == "chinese_sword1" || collision.gameObject.name == "chinese_sword1(Clone)")
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }
}