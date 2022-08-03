using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControllerMove : MonoBehaviour   
{
    float xRot;
    float yRot;
    float xRotCurrent;
    float yRotCurrent;
    public Camera player;
    public GameObject Playergameobject;
    public float sancivity = 5f;
    public float smoothTime = 0.1f;
    float CurrentVelocityX;
    float CurrentVelocitY;



    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    private void Update()
    {
        MoseMuve();
    }

    void MoseMuve()
    {
        xRot += Input.GetAxis("Mouse X") * sancivity;
        yRot += Input.GetAxis("Mouse Y") * sancivity;
        yRot = Mathf.Clamp(yRot, -90, 90);

        xRotCurrent = Mathf.SmoothDamp(xRotCurrent, xRot, ref CurrentVelocityX, smoothTime);
        yRotCurrent = Mathf.SmoothDamp(yRotCurrent, yRot, ref CurrentVelocitY, smoothTime);

        player.transform.rotation= Quaternion.Euler(-yRotCurrent, xRotCurrent, 0f);
        Playergameobject.transform.rotation = Quaternion.Euler(0f, xRotCurrent, 0f);

    }
}
