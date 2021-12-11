using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraRotation : MonoBehaviour
{
    public float YSens;
    public float PSens;

    public GameObject Origin;
    public GameObject Camera;
    public GameObject Hands;
    public GameObject Status;

    public float Yaw;
    public float Pitch;

    /*public float YawOffset = 0;
    public float PitchOffset = 0;

    [Range(0.0f, 1.0f)]
    public float OffsetFactor = 1.0f;

    public Vector3 firstRot;
    public Vector3 lastRot;
    public Vector3 calcRot;
    public Vector3 postRot;*/

    public AnimationCurve Rise;
    public AnimationCurve Fall;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        Yaw += YSens * Input.GetAxis("Mouse X");
        Pitch -= PSens * Input.GetAxis("Mouse Y");

        if (Pitch > 90)
        {
            Pitch = 90;
        }

        if (Pitch < -90)
        {
            Pitch = -90;
        }



        Origin.GetComponent<Transform>().localEulerAngles = new Vector3(0, Yaw, 0);
        Camera.GetComponent<Transform>().localEulerAngles = new Vector3(Pitch, 0, 0);
    }
}
