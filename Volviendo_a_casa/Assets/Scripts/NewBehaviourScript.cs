using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public int recuperacion;
    public GameObject Player;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Player.GetComponent<Vida_perro>().vidaPlayer += recuperacion;
            Destroy(gameObject);
        }


    }
}
