using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCamera : MonoBehaviour
{
    public Camera FpsCam, TpsCam;
    bool fpsCam = true;
    private KeyCode switchCam;
    void Start()
    {
        FpsCam.enabled = fpsCam;
        TpsCam.enabled = !fpsCam;
        if (this.gameObject == GameObject.Find("Player1"))
        {
            switchCam = KeyCode.G;
        }
        else if (this.gameObject == GameObject.Find("Player2"))
        {
            switchCam = KeyCode.L;
        }
    }
    void LateUpdate()
    {
        if (Input.GetKeyDown(switchCam))
        {
            fpsCam = !fpsCam;
            FpsCam.enabled = fpsCam;
            TpsCam.enabled = !fpsCam;
        }
    
    }
}
