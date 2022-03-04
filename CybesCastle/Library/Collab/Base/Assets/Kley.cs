using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kley : MonoBehaviour
{
    public GameObject obj;
    bool flag = false;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Cube" && flag == false)
        {
            FixedJoint component = obj.AddComponent<FixedJoint>();
            component.enableCollision = true;
            component.enablePreprocessing = true;
            component.connectedBody = collision.rigidbody;
            flag = true;
        }
    }

}
