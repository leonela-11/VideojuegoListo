using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vida_perro : MonoBehaviour
{
    public int vidaPlayer;
    public Slider vidaVisual;
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        vidaVisual.GetComponent<Slider>().value = vidaPlayer;

        if (vidaPlayer <= 0)
        {
            Debug.Log("Game Over");
        }
        if (vidaPlayer <= 0)
        {
            anim.SetBool("muerto", true);
            Time.timeScale = 1f;
            Respawn.gameOverManager.CallGameOver();
        }
        else
        {
            anim.SetBool("muerto", false);
            Time.timeScale = 1f;
        }
    }
}
