using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigrock : MonoBehaviour
{
    public GameObject HitObject;
    public GameObject DestroyObject;

    // Start is called before the first frame update
    void Start()
    {
        DestroyObject.active = false;
    }
    void OnCollisionEnter(Collider collision)
    {
        if (collision.tag == "Respawn")
        {
            HitObject.active = false;
            DestroyObject.active = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
