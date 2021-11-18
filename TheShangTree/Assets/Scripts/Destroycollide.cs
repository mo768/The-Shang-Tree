using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroycollide : MonoBehaviour
{

    void Start()
    {
        
    }

  
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        { Destroy(gameObject);
        }
    }
}
