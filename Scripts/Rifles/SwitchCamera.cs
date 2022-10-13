using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCamera : MonoBehaviour
{

    [Header("Camera to Assign")]
    public GameObject AimCam;
    public GameObject ThirdpersonCamera;

    // Update is called once per frame
    void Update()
    {

        if(Input.GetButton("Fire2") && Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            ThirdpersonCamera.SetActive(false);
            AimCam.SetActive(true);

        }else if (Input.GetButton("Fire2"))
        {
            ThirdpersonCamera.SetActive(false);
            AimCam.SetActive(true);
        }
        else
        {
            ThirdpersonCamera.SetActive(true);
            AimCam.SetActive(false);
        }


        
    }
}
