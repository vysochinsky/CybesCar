using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StopRotationCamera : MonoBehaviour
{
    public static GameObject obj;
    public static GameObject text;

    int ClickCount = 1;
    public CameraRotateAround R = obj.GetComponent<CameraRotateAround>();
    public Text T = text.GetComponent<Text>();

    public void StopRotation()
    {
        if(ClickCount%2 == 0)
        {
            R.enabled = true;
            ClickCount++;
            T.text = "Rotation ON";
            
        } else
        {
            R.enabled = false;
            ClickCount++;
            T.text = "Rotation OFF";
        }

    }

}
