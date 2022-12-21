using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transiciones : MonoBehaviour
{
    public float velocidadMovimiento = 1.0f;
    public float velocidadRotacion = 10.0f;
    private Animator anim;
    public float x, y;

    void Start()
    {
        anim = GetComponent<Animator>();
    }


    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");
        

        transform.Rotate(0, x * Time.deltaTime * velocidadRotacion, 0);
        transform.Translate(0, 0, y * Time.deltaTime * velocidadMovimiento);

        if (Input.GetKeyDown("up"))
        {
            anim.SetBool("adelante", true);
        }

        if (Input.GetKeyDown("down"))
        {
            anim.SetBool("atras", true);
        }

        if (Input.GetKeyUp("up"))
        {
            anim.SetBool("adelante", false);
        }

        if (Input.GetKeyUp("down"))
        {
            anim.SetBool("atras", false);
        }

        if (Input.GetKeyDown("space"))
        {
            anim.SetBool("saltar", true);
        }

        if (Input.GetKeyUp("space"))
        {
            anim.SetBool("saltar", false);
        }

        if (Input.GetKeyDown("right"))
        {
            anim.SetBool("derecha", true);
        }

        if (Input.GetKeyUp("right"))
        {
            anim.SetBool("derecha", false);
        }

        if (Input.GetKeyDown("left"))
        {
            anim.SetBool("izquierda", true);
        }

        if (Input.GetKeyUp("left"))
        {
            anim.SetBool("izquierda", false);
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Terreno_lento")
        {
            velocidadMovimiento = 2.0f;
        }

        if(other.tag != "Terreno_lento")
        {
            velocidadMovimiento = 10.0f;
        }
    }
}