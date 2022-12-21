    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pollos : MonoBehaviour
{
    public static int polloCount = 0;

    private void Start()
    {
        pollos.polloCount = pollos.polloCount + 1;
        
    }

    
    private void OnTriggerEnter(Collider otherCollider)
    {
        if (otherCollider.CompareTag("Player")== true)
        {

        }
       

        Destroy(gameObject);
    }
}
