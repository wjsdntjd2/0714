using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hero : MonoBehaviour
{
    Rigidbody rb;
    public float speed;
    Vector3 playerMove;
    bool Rolling;

    public float MoveNum;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        speed *= 3;
    }

    void FixedUpdate()
    {
        PlayerMove();
    }
    private void Update()
    {

    }
    void PlayerMove()
    {

        if (Rolling)
        {
            return;
        }
        if (Input.GetKey(KeyCode.W))
        {
            Rolling = true;
            StartCoroutine(Roll(transform.position + new Vector3(-0.5f, -0.5f, 0), Vector3.forward));
        }
        else if (Input.GetKey(KeyCode.A))
        {
            Rolling = true;
            StartCoroutine(Roll(transform.position + new Vector3(0, -0.5f, -0.5f), Vector3.left));
        }
        else if (Input.GetKey(KeyCode.S))
        {
            Rolling = true;
            StartCoroutine(Roll(transform.position + new Vector3(0.5f, -0.5f, 0), Vector3.back));
        }
        else if (Input.GetKey(KeyCode.D))
        {
            Rolling = true;
            StartCoroutine(Roll(transform.position + new Vector3(0, -0.5f, 0.5f), Vector3.right));
        }
    }

    IEnumerator Roll(Vector3 pivot,Vector3 _vec)
    {
        for (int i = 0; i < (90 / speed); i++) 
        {
            transform.RotateAround(pivot, _vec, speed);
            yield return new WaitForSeconds(0.01f);
        }
        Rolling = false;
    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("bullet"))
        {
            other.gameObject.SetActive(false);
            Debug.Log("a");
        }
    }
}
