using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public Camera Cam;
    public GameObject Eyes;
    public float Sensitivity = 1; 
    public bool Cutscene;

    public float rotX;
    public float rotY;

    void Start()
    {
        
    }

    void Update()
    {
        if (!Cutscene)
        {
            Cam.transform.position = Eyes.transform.position;
        }

        rotX = Input.GetAxis("Mouse X") * Sensitivity;
        rotY = Input.GetAxis("Mouse Y") * Sensitivity;

        Eyes.transform.Rotate(-rotY, rotX, 0);
    }
}
