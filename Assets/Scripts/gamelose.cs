using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class gamelose : MonoBehaviour
{
    void OnMouseDown()
    {
        SceneManager.LoadScene("main");
    }
}