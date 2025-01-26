using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class alpagu : MonoBehaviour
{
    #region var
    public Rigidbody2D alpagurigidbody2D;
    public GameObject alpagu_arrow;
    public GameObject alpagu_swordslash;
    public bool bool_weaponbow = true;
    public float float_countarrow = 5;
    public float float_health = 3;
    public float float_timer_weapon = 0;
    #endregion

    #region func
    void Update()
    {
        #region movement
        Vector2 movement = Vector2.zero;
        if (Input.GetKey(KeyCode.W))
        {
            movement.y = 1;
        }
        if (Input.GetKey(KeyCode.S))
        {
            movement.y = -1;
        }
        if (Input.GetKey(KeyCode.A))
        {
            movement.x = -1;
        }
        if (Input.GetKey(KeyCode.D))
        {
            movement.x = 1;
        }
        alpagurigidbody2D.velocity = movement * 8f;
        float border_x = Mathf.Clamp(alpagurigidbody2D.position.x, -8.5f, 8.5f);
        float border_y = Mathf.Clamp(alpagurigidbody2D.position.y, -4.5f, 2.25f);
        alpagurigidbody2D.position = new Vector3(border_x, border_y, 0);
        #endregion

        #region weapon
        if (0.5f > float_timer_weapon)
        {
            float_timer_weapon += Time.deltaTime;
        }
        else
        {
            if (bool_weaponbow)
            {
                if (float_countarrow > 0)
                {
                    if (Input.GetKey(KeyCode.Mouse0))
                    {
                        Instantiate(alpagu_arrow, transform.position + new Vector3(0.96f, 0, 0), transform.rotation);
                        float_countarrow -= 1;
                    }
                }
                if (Input.GetKey(KeyCode.Mouse1))
                {
                    bool_weaponbow = false;
                }
            }
            else
            {
                if (Input.GetKey(KeyCode.Mouse0))
                {
                    Instantiate(alpagu_swordslash, transform.position + new Vector3(1.92f, 0, 0), transform.rotation);
                }
                if (Input.GetKey(KeyCode.Mouse1))
                {
                    bool_weaponbow = true;
                }
            }
            float_timer_weapon = 0;
        }
        #endregion
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "item_arrow" || collision.gameObject.name == "item_arrow(Clone)")
        {
            Destroy(collision.gameObject);
            float_countarrow += 1;
        }
        if (collision.gameObject.name == "item_food" || collision.gameObject.name == "item_food(Clone)")
        {
            Destroy(collision.gameObject);
            float_health += 1;
        }
        if (collision.gameObject.name == "obstacle_barricade" || collision.gameObject.name == "obstacle_barricade(Clone)" || collision.gameObject.name == "obstacle_house" || collision.gameObject.name == "obstacle_house(Clone)")
        {
            Destroy(collision.gameObject);
            float_health -= 1;
        }
    }
    #endregion
}