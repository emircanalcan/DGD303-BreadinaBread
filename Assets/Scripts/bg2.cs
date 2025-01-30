using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class bg2 : MonoBehaviour
{
    void Update()
    {
        transform.position += Vector3.left * 2 * Time.deltaTime;
    }
}