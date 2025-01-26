using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class alpagu_swordslash : MonoBehaviour
{
    public GameObject item_arrow;
    void Start()
    {
        Destroy(gameObject, 0.25f);
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "obstacle_barricade" || collision.gameObject.name == "obstacle_barricade(Clone)")
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
            Instantiate(item_arrow, transform.position + new Vector3(1.28f, 0, 0), transform.rotation);
        }
    }
}