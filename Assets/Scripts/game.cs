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
    public GameObject obstacle_tree1;
    public GameObject obstacle_tree2;
    public float float_spawn_limit = 0;
    public float float_spawn_timer = 0;
    public int int_spawn_index = 0;
    List<List<float>> list_instantiate = new List<List<float>> {
        new List<float> { 0.4f, 5, -1.25f },
        new List<float> { 0.4f, 6, 1.25f },
        new List<float> { 0.4f, 5, -2.5f },
        new List<float> { 4, 4, -1.25f }
    };
    void Update()
    {
        if (float_spawn_limit > float_spawn_timer)
        {
            float_spawn_timer += Time.deltaTime;
        }
        else
        {
            if (4 > int_spawn_index)
            {
                for (int i = 1; i < list_instantiate[int_spawn_index].Count; i += 2)
                {
                    switch (list_instantiate[int_spawn_index][i])
                    {
                        case 0:
                            break;
                        case 1:
                            Instantiate(chinese_bow1, transform.position + new Vector3(0, list_instantiate[int_spawn_index][i + 1], 0), transform.rotation);
                            break;
                        case 2:
                            Instantiate(chinese_sword1, transform.position + new Vector3(0, list_instantiate[int_spawn_index][i + 1], 0), transform.rotation);
                            break;
                        case 3:
                            Instantiate(obstacle_barricade, transform.position + new Vector3(0, list_instantiate[int_spawn_index][i + 1], 0), transform.rotation);
                            break;
                        case 4:
                            Instantiate(obstacle_house, transform.position + new Vector3(0, list_instantiate[int_spawn_index][i + 1], 0), transform.rotation);
                            break;
                        case 5:
                            Instantiate(obstacle_tree1, transform.position + new Vector3(0, list_instantiate[int_spawn_index][i + 1], 0), transform.rotation);
                            break;
                        case 6:
                            Instantiate(obstacle_tree2, transform.position + new Vector3(0, list_instantiate[int_spawn_index][i + 1], 0), transform.rotation);
                            break;
                    }
                }
                float_spawn_limit = list_instantiate[int_spawn_index][0];
                float_spawn_timer = 0;
                int_spawn_index += 1;
            }
            else
            {
                SceneManager.LoadScene("gamewin");
            }
        }
    }
}