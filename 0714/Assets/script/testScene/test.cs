using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public Transform MuzzelTrans;
    float MuzzelMoveTime;
    public float MuzzelMoveStartTime;
    bool MoveMuzzel;

    void Update()
    {
        //MuzzelMoveTime += Time.deltaTime;
        Vector3 vPos = Input.mousePosition;
        vPos.z = -Camera.main.transform.position.z;

        Vector3 dir = Camera.main.ScreenToWorldPoint(vPos) - MuzzelTrans.position;
        dir.Normalize();
        Quaternion rot = Quaternion.LookRotation(dir);
        MuzzelTrans.rotation = Quaternion.Lerp(MuzzelTrans.rotation, rot, 1.0f);
        //if (Input.GetMouseButtonDown(0))
        //{
        //    MoveMuzzel = true;
        //}
        //if (MoveMuzzel)
        //{
        //    if (MuzzelMoveTime >= MuzzelMoveStartTime)
        //    {
        //        MoveMuzzel = false;
        //        MuzzelMoveTime = 0;
        //    }
        //    else
        //    {

        //    }
        //}
    }
}
