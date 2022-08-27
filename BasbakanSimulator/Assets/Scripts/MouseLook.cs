using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    [Range(50, 500)]
    public float sens;

    public Transform body;

    float xRot = 0f;

    public Camera cam;
    public float defaultFov = 60;


    private void Update()
    {
        float rotX = Input.GetAxisRaw("Mouse X") * sens * Time.deltaTime;
        float rotY = Input.GetAxisRaw("Mouse Y") * sens * Time.deltaTime;

        xRot -= rotY;

        xRot = Mathf.Clamp(xRot, -80f, 80);

        transform.localRotation = Quaternion.Euler(xRot, 0f, 0f);

        body.Rotate(Vector3.up * rotX);

        if (Input.GetMouseButton(1))
        {
            cam.fieldOfView = (defaultFov / 2);
        }
        else
        {
            cam.fieldOfView = (defaultFov);
        }

    }
}
