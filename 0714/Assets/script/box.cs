using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class box : MonoBehaviour
{
    public Transform muzzel;
    public GameObject Bullet;
    public Transform Target;

    public float BulletShotTime;
    float ShotTime;
    public float BulletSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if(Input.GetKeyDown(KeyCode.A))
        //{
        //    Instantiate(Bullet, muzzel);
        //}

        ShotTime += Time.deltaTime;
        if (ShotTime>=BulletShotTime)
        {
            Instantiate(Bullet, muzzel);
            ShotTime = 0;
        }
        BulletShotTime -= 0.02f * Time.deltaTime;


        Vector3 dir = Target.transform.position - transform.position;
        dir = new Vector3(dir.x, 0, dir.z);
        Quaternion rot = Quaternion.LookRotation(dir);
        transform.rotation = Quaternion.Lerp(transform.rotation, rot, 0.15f);

        //transform.LookAt(Target);
    }
}
