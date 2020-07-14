using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    Rigidbody rb;
    IEnumerator Disable()
    {
        yield return new WaitForSeconds(5);
        Destroy(gameObject);
    }
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * Mng.Ins.box.BulletSpeed);
        transform.SetParent(null);
        StartCoroutine(Disable());
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
    }
}
