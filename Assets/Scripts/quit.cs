using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class quit : MonoBehaviour
{
    void OnMouseDown()
    {
        Application.Quit();
    }
}