using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLayer_Con : MonoBehaviour
{
    float rot_Y = 100.0f;
    float rot_X = 100.0f;
    float tran_X = 10.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Rotate(-rot_X*Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.X))
        {
            transform.Rotate(rot_X*Time.deltaTime ,0, 0);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            //transform.Rotate(0, -rot_Y * Time.deltaTime, 0);
            transform.rotation = Quaternion.Euler(0, -rot_Y * Time.deltaTime, 0);
        
        }

        if (Input.GetKey(KeyCode.E))
        {
            //transform.Rotate(0, rot_Y * Time.deltaTime, 0);
            transform.rotation = Quaternion.Euler(0, rot_Y * Time.deltaTime, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-tran_X*Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(tran_X * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.rotation = Quaternion.Euler(0,0,0);
        }

    }
}
