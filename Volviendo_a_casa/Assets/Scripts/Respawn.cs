using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Respawn : MonoBehaviour
{
    public GameObject GameOver;
    public static Respawn gameOverManager;

    void Start()
    {
        gameOverManager = this;
    }

    void Update()
    {
      
    }
    public void CallGameOver()
    {
        GameOver.SetActive(true);
    }
}
