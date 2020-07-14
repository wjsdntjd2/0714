using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wind : MonoBehaviour
{
    float WindNum;
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        WindNum = 1;
        if(WindNum==0)
        {

        }
        else if(WindNum==1)
        {
            rb.AddForce(new Vector3(0, 0, -250));
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {

        }
    }
}
