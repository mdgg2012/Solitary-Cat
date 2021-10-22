using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrimeraPersona : MonoBehaviour
{
    private new Transform camera;
    public Vector2 sensibility;

    void Start()
    {
        camera = transform.Find("Camera");
        Cursor.lockState = CursorLockMode.Locked;
    }


    void Update()
    {
        float hor = Input.GetAxis("Mouse X");
        float ver = Input.GetAxis("Mouse Y");

        if (hor != 0)
        {
            transform.Rotate(Vector3.up * hor * sensibility);
        }

        if (ver != 0)
        {
            float angle = camera.localEulerAngles.x - ver * sensibility.y;
            camera.localEulerAngles = Vector3.right * angle;
        }
    }
}
