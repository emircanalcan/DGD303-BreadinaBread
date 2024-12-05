using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class alpagu_arrow : MonoBehaviour
{
    void Start()
    {
        Destroy(gameObject, 1.125f);
    }
    void Update()
    {
        transform.position += Vector3.right * 16 * Time.deltaTime;
    }
}