using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateConnect : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Cube")
        {
            gameObject.AddComponent<FixedJoint>();
            var myscript = gameObject.GetComponent<FixedJoint>();
            myscript.connectedBody = collision.rigidbody;
            myscript.breakForce = 100;
        }
    }
}