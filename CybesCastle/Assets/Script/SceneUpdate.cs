using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneUpdate : MonoBehaviour
{
    public void RestartLevel()
    {
        SceneManager.LoadScene("Cubes");
    }
}