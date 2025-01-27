using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class game : MonoBehaviour
{
    public GameObject chinese_bow1;
    public GameObject chinese_sword1;
    public GameObject obstacle_barricade;
    public GameObject obstacle_house;
    public float float_timer_spawn = 0;
    void Update()
    {
        float_timer_spawn += Time.deltaTime;

    }
}