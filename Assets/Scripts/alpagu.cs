using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class alpagu : MonoBehaviour
{
    #region var
    public Rigidbody2D alpagurigidbody2D;
    public GameObject alpagu_arrow;
    public GameObject alpagu_swordslash;
    private bool bool_weaponbow = false;
    private float float_weaponrate = 0.5f;
    private float float_timer = 0;
    #endregion

    #region func
    public void func_weapon(GameObject prefab, float offset, bool weaponbow)
    {
        if (Input.GetKey(KeyCode.Mouse0)|| Input.GetKey(KeyCode.M))
        {
            Instantiate(prefab, transform.position + new Vector3(offset, 0, 0), transform.rotation);
            float_timer = 0;
        }
        if (Input.GetKey(KeyCode.Mouse1)|| Input.GetKey(KeyCode.N))
        {
            bool_weaponbow = weaponbow;
            float_timer = 0;
        }
    }
    void Start()
    {

    }
    void Update()
    {
        #region movement
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
        #endregion

        #region weapon
        if (float_weaponrate > float_timer)
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