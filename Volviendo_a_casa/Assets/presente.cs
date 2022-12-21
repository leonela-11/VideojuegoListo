using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class presente : MonoBehaviour
{
    void Update()
    {
        if (!GameObject.FindGameObjectWithTag("pollo"))
        {
            print("Comiste todos los pollos y pasas de nivel");
            SceneManager.LoadScene(2);
        }
    }
}
