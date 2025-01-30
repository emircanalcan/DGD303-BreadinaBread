using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class gamewin : MonoBehaviour
{
    void OnMouseDown()
    {
        SceneManager.LoadScene("main");
    }
}