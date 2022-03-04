using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCube : MonoBehaviour
{
    public GameObject[] objects;
    Vector3 MousePos;
    Vector3 Direction;
    Vector3 Pos;

    int a;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Input.GetMouseButtonDown(0))
        if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject.tag == "Cube")
                {
                    if (hit.collider.transform.position.x - hit.point.x >= 0.5f)
                    {
                        var pos = new Vector3(hit.collider.transform.position.x - 2.0f, hit.collider.transform.position.y, hit.collider.transform.position.z);
                        Instantiate(objects[0], pos, Quaternion.identity);
                    }
                    else if (hit.collider.transform.position.x - hit.point.x <= -0.49f)
                    {
                        var pos = new Vector3(hit.collider.transform.position.x + 2.0f, hit.collider.transform.position.y, hit.collider.transform.position.z);
                        Instantiate(objects[0], pos, Quaternion.identity);
                    }
                    else if (hit.collider.transform.position.y - hit.point.y >= 0.5f)
                    {
                        var pos = new Vector3(hit.collider.transform.position.x, hit.collider.transform.position.y - 2.0f, hit.collider.transform.position.z);
                        Instantiate(objects[0], pos, Quaternion.identity);
                    }
                    else if (hit.collider.transform.position.y - hit.point.y <= -0.49f)
                    {
                        var pos = new Vector3(hit.collider.transform.position.x, hit.collider.transform.position.y + 2.0f, hit.collider.transform.position.z);
                        Instantiate(objects[0], pos, Quaternion.identity);
                    }
                    else if (hit.collider.transform.position.z - hit.point.z >= 0.5f)
                    {
                        var pos = new Vector3(hit.collider.transform.position.x, hit.collider.transform.position.y, hit.collider.transform.position.z - 2.0f);
                        Instantiate(objects[0], pos, Quaternion.identity);
                    }
                    else if (hit.collider.transform.position.z - hit.point.z <= -0.49f)
                    {
                        var pos = new Vector3(hit.collider.transform.position.x, hit.collider.transform.position.y, hit.collider.transform.position.z + 2.0f);
                        Instantiate(objects[0], pos, Quaternion.identity);
                    }
                }
        }
    }

}
