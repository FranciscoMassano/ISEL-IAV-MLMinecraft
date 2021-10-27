using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCamera : MonoBehaviour
{
    public Camera FirstCamera;
    public Camera Thirdcamera;
    bool FirstPerCmaeraControl = false;
    public GameObject ch09;

    bool bumper1;
    bool bumper2;
    bool bumper3;
    bool bumper4;
    bool bumper5;
    bool bumper6;
    bool bumper7;
    bool bumper8;

    public void setBumper1(bool setbumper)
    {
        this.bumper1 = setbumper;
    }

    public void setBumper2(bool setbumper)
    {
        this.bumper2 = setbumper;
    }
    public void setBumper3(bool setbumper)
    {
        this.bumper3 = setbumper;
    }
    public void setBumper4(bool setbumper)
    {
        this.bumper4 = setbumper;
    }

    public void setBumper5(bool setbumper)
    {
        this.bumper5 = setbumper;
    }

    public void setBumper6(bool setbumper)
    {
        this.bumper6 = setbumper;
    }
    public void setBumper7(bool setbumper)
    {
        this.bumper7 = setbumper;
    }
    public void setBumper8(bool setbumper)
    {
        this.bumper8 = setbumper;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
            FirstPerCmaeraControl = !FirstPerCmaeraControl;


        if (FirstPerCmaeraControl || bumper1 && bumper2 && bumper3 && bumper4 && bumper5 && bumper6 && bumper7 && bumper8)
        {
            Thirdcamera.enabled = false;
            FirstCamera.enabled = true;
            ch09.GetComponent<SkinnedMeshRenderer>().enabled = false;
        }
        else
        {
            Thirdcamera.enabled = true;
            FirstCamera.enabled = false;
            ch09.GetComponent<SkinnedMeshRenderer>().enabled = true;
        }
    }
}
