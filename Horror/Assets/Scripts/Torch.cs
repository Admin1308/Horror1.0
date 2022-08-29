
using UnityEngine;

public class Torch : MonoBehaviour
{
    public AudioSource Torchsound;
    public Light FL;


    float xRot;
    float yRot;
    float xRotCurrent;
    float yRotCurrent;
    public GameObject player;
    public GameObject Playergameobject;
    public float sancivity = 1f;
    public float smoothTime = 0.08f;
    float CurrentVelocityX;
    float CurrentVelocitY;


 
    private void Update()
    {
        isActivityTorch();
     //   Torchsmootch();
    }


    private void isActivityTorch()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            FL.enabled = !FL.enabled;
            Torchsound.Play();
        }
    }
    //void Torchsmootch()
    //{
    //   xRot += Input.GetAxis("Mouse X") * sancivity;
    //   yRot += Input.GetAxis("Mouse Y") * sancivity;
    //   yRot = Mathf.Clamp(yRot, -90, 90);

    //    xRotCurrent = Mathf.SmoothDamp(xRotCurrent, xRot, ref CurrentVelocityX, smoothTime);
    //    yRotCurrent = Mathf.SmoothDamp(yRotCurrent, yRot, ref CurrentVelocitY, smoothTime);

    //    player.transform.rotation = Quaternion.Euler(-yRotCurrent, xRotCurrent, 0f);
    //    Playergameobject.transform.rotation = Quaternion.Euler(0f, xRotCurrent, 0f);

    //}
}
