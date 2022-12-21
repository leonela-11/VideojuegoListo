using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disminuye_velocidad : MonoBehaviour
{
    public int get_low;
    public GameObject Player;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Player.GetComponent<transiciones>().velocidadMovimiento = 5.0f;
        }

        if (other.tag == "Enemigo")
        {
            Debug.Log("Esto es un enemigo");
        }
    }
}