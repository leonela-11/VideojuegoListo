using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music_control : MonoBehaviour
{
    public static Music_control Instance;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        if(Instance == null)
        {
            Instance=this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
