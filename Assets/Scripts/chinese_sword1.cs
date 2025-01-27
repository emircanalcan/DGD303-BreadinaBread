using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class chinese_sword1 : MonoBehaviour
{
    public GameObject chinese_swordslash;
    public float float_timer_weapon = 0.8f;
    void Update()
    {
        transform.position += Vector3.left * 8 * Time.deltaTime;
        if (0.8f > float_timer_weapon)
        {
            float_timer_weapon += Time.deltaTime;
        }
        else
        {
            Instantiate(chinese_swordslash, transform.position + new Vector3(-1.92f, 0, 0), transform.rotation);
            float_timer_weapon = 0;
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "border_left")
        {
            Destroy(gameObject);
        }
    }
}