using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Danio_auto : MonoBehaviour
{
    public int damage;
    public GameObject Player;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Debug.Log("Esta es la vida del zorro");
            Debug.Log(Player.GetComponent<Vida_perro>().vidaPlayer);
            Player.GetComponent<Vida_perro>().vidaPlayer -= damage;

        }

        if (other.tag == "Enemigo")
        {
            Debug.Log("Esto es un enemigo");
        }
    }
}