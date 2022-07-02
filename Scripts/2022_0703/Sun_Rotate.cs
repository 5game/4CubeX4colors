using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sun_Rotate : MonoBehaviour
{
    public float x = 0;
    //float y = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(x+10*Time.deltaTime, 0, 0); 
        
               }
    }

