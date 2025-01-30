using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class bg1 : MonoBehaviour
{
    void Update()
    {
        transform.position += Vector3.left * 0.5f * Time.deltaTime;
    }
}