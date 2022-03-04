using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kley : MonoBehaviour
{
    public GameObject obj;
    bool flag = false;
    Vector3 s;
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
            s = collision.transform.position;
            s = s - obj.transform.position;
            if (Mathf.Abs(s.x) > Mathf.Abs(s.z) && Mathf.Abs(s.x) > Mathf.Abs(s.y))
                obj.transform.position = new Vector3(collision.transform.position.x + s.x, collision.transform.position.y, collision.transform.position.z);
            if (Mathf.Abs(s.y) > Mathf.Abs(s.x) && Mathf.Abs(s.y) > Mathf.Abs(s.z))
                obj.transform.position = new Vector3(collision.transform.position.x , collision.transform.position.y+ s.y, collision.transform.position.z);
            if (Mathf.Abs(s.z) > Mathf.Abs(s.x) && Mathf.Abs(s.z) > Mathf.Abs(s.y))
                obj.transform.position = new Vector3(collision.transform.position.x , collision.transform.position.y, collision.transform.position.z+s.z);
            FixedJoint component = obj.AddComponent<FixedJoint>();
            component.enableCollision = true;
            component.enablePreprocessing = true;
            component.connectedBody = collision.rigidbody;
            flag = true;
            
        }
    }

}
