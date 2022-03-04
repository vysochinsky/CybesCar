using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wheel : MonoBehaviour
{
    public Rigidbody rb;
    bool ButtonDown = false;
    int derection;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (ButtonDown == true)
            rb.AddForce(Vector3.right * 50f * derection);
    }
    public void OnButtonDown()
    {
        ButtonDown = true;
        derection = 1;
    }
    public void OnButtonUp()
    {
        ButtonDown = false;
        derection = 0;
    }
    public void OnButtonDownLeft()
    {
        ButtonDown = true;
        derection = -1;
    }
}