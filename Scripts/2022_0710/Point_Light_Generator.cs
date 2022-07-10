using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point_Light_Generator : MonoBehaviour 
    //1초마다 포인트 라이트가 켜졌다 꺼졌다하는 기능

{
    Light point_Light; //라이트 컴포넌트를 대입할 변수
    float span = 1.0f; //간격값을 대입할 변수 와 값
    float delta = 0; //타임.델타타임의 초기값
    void Start()
    {
        point_Light = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        delta += Time.deltaTime;
        if (delta > span)
        {
            delta = 0;
            point_Light.intensity = Random.Range(0, 20);

        }
        point_Light.range = Random.Range(0, 20);
    }
}
