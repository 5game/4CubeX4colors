using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point_Light_Generator : MonoBehaviour 
    //1�ʸ��� ����Ʈ ����Ʈ�� ������ �������ϴ� ���

{
    Light point_Light; //����Ʈ ������Ʈ�� ������ ����
    float span = 1.0f; //���ݰ��� ������ ���� �� ��
    float delta = 0; //Ÿ��.��ŸŸ���� �ʱⰪ
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
