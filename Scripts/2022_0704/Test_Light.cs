using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_Light : MonoBehaviour
{
    Light point_Light;
    float add_Intensity;
    float start_Intensity;
    // Start is called before the first frame update
    void Start()
    {
        point_Light = GetComponent<Light>();
        start_Intensity = point_Light.intensity;
        add_Intensity = Random.Range(0.5f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Mathf.Abs(add_Intensity - start_Intensity) >= 0.01)
        {
            if (add_Intensity-start_Intensity >=0)
            {
                start_Intensity += Time.deltaTime * 3f;
            }
            else
            {
                start_Intensity -= Time.deltaTime * 3f;
            }
            point_Light.intensity = start_Intensity;
            point_Light.range = start_Intensity+3;
        }
        else
        {
            add_Intensity = Random.Range(0.5f, 1f);
        }
    }
}
