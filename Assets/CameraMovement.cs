using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    public float MouseSpeed;

    public Transform Player;

    public float xRotation = 0f;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float MouseX = Input.GetAxis("Mouse X") * MouseSpeed * Time.deltaTime;
        float MouseY = Input.GetAxis("Mouse Y") * MouseSpeed * Time.deltaTime;

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        Player.Rotate(Vector3.up * MouseX);

        xRotation -= MouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
    }
}
