using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PController : MonoBehaviour
{
    float mSpeed = 10.0f;
    float rSpeed = 150.0f;
    [SerializeField]
    Material color_Mat1;
    [SerializeField]
    Material color_Mat2;
    [SerializeField]
    Material color_Mat3;
    [SerializeField]
    Material color_Mat4;
    MeshRenderer mesh;

    // Update is called once per frame

    private void Start()
    {
        mesh = GetComponent<MeshRenderer>();
    }
    void Update()
    {
        float m = Input.GetAxis("Vertical") * mSpeed * Time.deltaTime;
        float r = Input.GetAxis("Horizontal") * rSpeed * Time.deltaTime;

        transform.Translate(0, 0, m);
        transform.Rotate(0, r, 0);

        if (Input.GetMouseButton(0))
        {
            mesh.material = color_Mat1;
        }
        else if (Input.GetMouseButton(1))
        {
            mesh.material = color_Mat2;
        }
        else if (Input.GetMouseButton(2))
        { mesh.material = color_Mat3;
        }
        else
        {
            mesh.material = color_Mat4;
        }
    }
}
