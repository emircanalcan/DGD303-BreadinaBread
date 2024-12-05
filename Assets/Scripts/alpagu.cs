using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class alpagu : MonoBehaviour
{
    #region var
    public Rigidbody2D alpagurigidbody2D;
    public GameObject alpagu_arrow;
    public GameObject alpagu_swordslash;
    private bool bool_weaponbow = true;
    private float float_timer = 0;
    #endregion

    #region func
    public void func_weapon(GameObject prefab, float offset, bool weaponbow)
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            Instantiate(prefab, transform.position + new Vector3(offset, 0, 0), transform.rotation);
            float_timer = 0;
        }
        if (Input.GetKey(KeyCode.Mouse1))
        {
            bool_weaponbow = weaponbow;
            float_timer = 0;
        }
    }
    void FixedUpdate()
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
        alpagurigidbody2D.velocity = movement.normalized * 8f;
        if (alpagurigidbody2D.position.y > 2.25f)
        {
            alpagurigidbody2D.position = new Vector3(alpagurigidbody2D.position.x, 2.25f, 0);
        }
        if (-4.5f > alpagurigidbody2D.position.y)
        {
            alpagurigidbody2D.position = new Vector3(alpagurigidbody2D.position.x, -4.5f, 0);
        }
        if (alpagurigidbody2D.position.x > 8.5f)
        {
            alpagurigidbody2D.position = new Vector3(8.5f, alpagurigidbody2D.position.y, 0);
        }
        if (-8.5f > alpagurigidbody2D.position.x)
        {
            alpagurigidbody2D.position = new Vector3(-8.5f, alpagurigidbody2D.position.y, 0);
        }
        #endregion
    }
    void Update()
    {
        #region weapon
        if (0.5f > float_timer)
        {
            float_timer += Time.deltaTime;
        }
        else
        {
            if (bool_weaponbow)
            {
                func_weapon(alpagu_arrow, 1, false);
            }
            else
            {
                func_weapon(alpagu_swordslash, 2, true);
            }
        }
        #endregion
    }
    #endregion
}